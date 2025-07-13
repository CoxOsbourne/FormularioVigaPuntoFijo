using System;
using System.Collections;
using System.Collections.Generic;
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
    public class PluginData
    {
        #region Fields
        //
        // Define the fields specified on the Form.
        //
        [StructuresField("Length")]
        public double Length;

        [StructuresField("Profile")]
        public string Profile;

        [StructuresField("Material")]
        public string Material;
        #endregion
    }

    [Plugin("FormularioVigaPuntoFijo")]
    [PluginUserInterface("FormularioVigaPuntoFijo.MainForm")]
    public class FormularioVigaPuntoFijo : PluginBase
    {
        #region Fields
        private PluginData Data { get; set; }
        
        #endregion

        #region Properties
        
        #endregion

        #region Constructor
        public FormularioVigaPuntoFijo(PluginData data)
        {
            Data = data;                    
        }
        #endregion

        #region Overrides
        public override List<InputDefinition> DefineInput()
        {
            //para hacer la viga desde un punto fijo (SIN SELECCIONAR CON EL RATÓN), con un plugin tienes que devolver la lista vacía; ni eso. La lógica va en el botón, en el code-behind
            //if you want to make a beam starting from a fixed point (NO MOUSE SELECTION), with a plugin you should return an empty list. Logic goes in the button, in the code behind
            return new List<InputDefinition> (); 
        }

        public override bool Run(List<InputDefinition> Input)
        {
            //aquí no se hace NADA, sino Tekla decidirá llamar a funciones, y tu formulario no vale nada
            //nothing gets done here, otherwise Tekla will call methods, and your form will be useless
            return true;
        }
        #endregion

        #region Public Method for External Call
        //Ignora esta región, es inútil
        //Nevermind this region, is useless
        #endregion

        #region Private methods
        /// <summary>
        /// Gets the values from the dialog and sets the default values if needed
        /// </summary>
        /*private void GetValuesFromDialog() //Esto no hace falta, se hace todo en el botón //this is not needed, everything is done in the button
        {
            //olvídate de las variables, todo ocurre en el botón
            //forget about variables, everything happens inside the button
            _Length = Data.Length;
            _Profile = Data.Profile;
            _Material = Data.Material;

            if(IsDefaultValue(_Length) || _Length<=0)
            {
                _Length = 2800;
            }
            if (IsDefaultValue(_Profile))
            {
                _Profile = "HEA200";
            }
            if (IsDefaultValue(_Material))
            {
                _Material = "S235JR";
            }
        }*/

        // Write your private methods here.
        //En este plugin cutre no hace falta. Todo ocurre en el botón. Vete al archivo del formulario
        //In this poor plugin, methods are in the button. Go to the form file
        #endregion
    }
}
