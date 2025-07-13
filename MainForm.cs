using System;
using System.Globalization;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Datatype;
using Tekla.Structures.Dialog;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using static Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions;
using TSG = Tekla.Structures.Geometry3d;
using TSM = Tekla.Structures.Model;

namespace FormularioVigaPuntoFijo
{
    public partial class MainForm : Tekla.Structures.Dialog.PluginFormBase
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
   
        private void OkApplyModifyGetOnOffCancel_OkClicked(object sender, EventArgs e)
        {
            //olvídate de estos botones que vienen en la plantilla y crea uno. En serio, te ahorrará dolores de cabeza
            //forget about this and make a button for creating the beam, honestly
            this.Apply();
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel_ApplyClicked(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void OkApplyModifyGetOnOffCancel_ModifyClicked(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel_GetClicked(object sender, EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel_OnOffClicked(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }

        private void OkApplyModifyGetOnOffCancel_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profileCatalogSelectClicked(object sender, EventArgs e)
        {
            profileCatalog.SelectedProfile=textBoxProfile.Text;
        }

        private void profileCatalogSelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBoxProfile, profileCatalog.SelectedProfile);
        }

        private void materialCatalogSelectClicked(object sender, EventArgs e)
        {
            materialCatalog.SelectedMaterial = textBoxMaterial.Text;
        }

        private void materialCatalogSelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBoxMaterial, materialCatalog.SelectedMaterial);
        }

        //la magia ocurre aquí. Lógica de creación de viga de aquí en adelante
        //magic occurs here. Beam creation logic from here on
        private void buttonCreateBeam_Click(object sender, EventArgs e)
        {
            this.Get();   // recoge valores actuales del formulario
            this.Apply(); // los sincroniza con el plugin //synchronizes form values with the plugin

            try
            {
                // Obtener valores directamente desde los TextBox //Obtain values directly from TextBoxes
                
                if (!double.TryParse(textBoxLength.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double length))
                {
                    length = 2800.0; // valor por defecto //default value
                }

                //lectura de valores en los TextBox
                //reading values from TextBoxes
                string profile = textBoxProfile.Text;
                string material = textBoxMaterial.Text;

                Model model = new Tekla.Structures.Model.Model();

                //designación de puntos
                //point designation
                TSG.Point start = new Tekla.Structures.Geometry3d.Point(0, 0, 0);
                TSG.Point end = new Tekla.Structures.Geometry3d.Point(length, 0, 0); //length. La viga va por el eje x. Beam goes through x axis

                //llamada a función para crear viga
                //beam creation method call
                TSM.ModelObject beam = CreateBeam(start,end,profile,material);
                model.CommitChanges();
                //MessageBox.Show("Viga creada correctamente."); //mensaje de verificación //verification message
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la viga: " + ex.Message);
            }
        }

        //Función que crea la viga
        //Method that creates the beam
        private TSM.ModelObject CreateBeam(TSG.Point point1, TSG.Point point2,string profile,string material)
        {
            TSM.Beam beam = new TSM.Beam(point1,point2); //Beam puede tener 2 puntos. Ver documentación de la API de Tekla Structures //Beam can receive 2 points. See Tekla Structures API documentation
            beam.Profile.ProfileString = profile;
            beam.Material.MaterialString = material;
            //beam.Finish = "PAINT"; //ponlo si quieres //put this if you want 
            beam.Class = "2";
            beam.StartPoint.X = point1.X;
            beam.StartPoint.Y = point1.Y;
            beam.StartPoint.Z = point1.Z;
            beam.EndPoint.X = point2.X;
            beam.EndPoint.Y = point2.Y;
            beam.EndPoint.Z = point2.Z;
            beam.Position.Rotation = TSM.Position.RotationEnum.TOP;
            beam.Position.Plane = TSM.Position.PlaneEnum.MIDDLE;
            beam.Position.Depth = TSM.Position.DepthEnum.FRONT;
            if (!beam.Insert())
            {
                Console.WriteLine("Insertion of beam failed.");
            }
            return beam;
        }
    }
}