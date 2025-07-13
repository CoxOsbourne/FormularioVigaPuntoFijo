namespace FormularioVigaPuntoFijo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ParametersTabPage = new System.Windows.Forms.TabPage();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.materialCatalog = new Tekla.Structures.Dialog.UIControls.MaterialCatalog();
            this.textBoxProfile = new System.Windows.Forms.TextBox();
            this.profileCatalog = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.saveLoad = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.buttonCreateBeam = new System.Windows.Forms.Button();
            this.OkApplyModifyGetOnOffCancel = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.ParametersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.structuresExtender.SetAttributeName(this.tableLayoutPanel, null);
            this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel, null);
            this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel, null);
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.OkApplyModifyGetOnOffCancel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.saveLoad, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(534, 414);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.structuresExtender.SetAttributeName(this.tabControl, null);
            this.structuresExtender.SetAttributeTypeName(this.tabControl, null);
            this.structuresExtender.SetBindPropertyName(this.tabControl, null);
            this.tabControl.Controls.Add(this.ParametersTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(528, 324);
            this.tabControl.TabIndex = 18;
            // 
            // ParametersTabPage
            // 
            this.structuresExtender.SetAttributeName(this.ParametersTabPage, null);
            this.structuresExtender.SetAttributeTypeName(this.ParametersTabPage, null);
            this.structuresExtender.SetBindPropertyName(this.ParametersTabPage, null);
            this.ParametersTabPage.Controls.Add(this.buttonCreateBeam);
            this.ParametersTabPage.Controls.Add(this.textBoxLength);
            this.ParametersTabPage.Controls.Add(this.label1);
            this.ParametersTabPage.Controls.Add(this.textBoxMaterial);
            this.ParametersTabPage.Controls.Add(this.materialCatalog);
            this.ParametersTabPage.Controls.Add(this.textBoxProfile);
            this.ParametersTabPage.Controls.Add(this.profileCatalog);
            this.ParametersTabPage.Location = new System.Drawing.Point(4, 22);
            this.ParametersTabPage.Name = "ParametersTabPage";
            this.ParametersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParametersTabPage.Size = new System.Drawing.Size(520, 298);
            this.ParametersTabPage.TabIndex = 2;
            this.ParametersTabPage.Text = "albl_Parameters";
            this.ParametersTabPage.UseVisualStyleBackColor = true;
            // 
            // textBoxLength
            // 
            this.structuresExtender.SetAttributeName(this.textBoxLength, "Length");
            this.structuresExtender.SetAttributeTypeName(this.textBoxLength, "Distance");
            this.structuresExtender.SetBindPropertyName(this.textBoxLength, null);
            this.textBoxLength.Location = new System.Drawing.Point(170, 74);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 9;
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(34, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Longitud";
            // 
            // textBoxMaterial
            // 
            this.structuresExtender.SetAttributeName(this.textBoxMaterial, "Material");
            this.structuresExtender.SetAttributeTypeName(this.textBoxMaterial, "String");
            this.structuresExtender.SetBindPropertyName(this.textBoxMaterial, "Text");
            this.textBoxMaterial.Location = new System.Drawing.Point(170, 180);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterial.TabIndex = 7;
            this.textBoxMaterial.Tag = "Material";
            // 
            // materialCatalog
            // 
            this.structuresExtender.SetAttributeName(this.materialCatalog, null);
            this.structuresExtender.SetAttributeTypeName(this.materialCatalog, null);
            this.materialCatalog.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.materialCatalog, null);
            this.materialCatalog.ButtonText = "Material";
            this.materialCatalog.Location = new System.Drawing.Point(17, 180);
            this.materialCatalog.Name = "materialCatalog";
            this.materialCatalog.SelectedMaterial = "";
            this.materialCatalog.Size = new System.Drawing.Size(88, 27);
            this.materialCatalog.TabIndex = 6;
            this.materialCatalog.SelectClicked += new System.EventHandler(this.materialCatalogSelectClicked);
            this.materialCatalog.SelectionDone += new System.EventHandler(this.materialCatalogSelectionDone);
            // 
            // textBoxProfile
            // 
            this.structuresExtender.SetAttributeName(this.textBoxProfile, "Profile");
            this.structuresExtender.SetAttributeTypeName(this.textBoxProfile, "String");
            this.structuresExtender.SetBindPropertyName(this.textBoxProfile, "Text");
            this.textBoxProfile.Location = new System.Drawing.Point(170, 124);
            this.textBoxProfile.Name = "textBoxProfile";
            this.textBoxProfile.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfile.TabIndex = 5;
            this.textBoxProfile.Tag = "Profile";
            // 
            // profileCatalog
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalog, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalog, null);
            this.profileCatalog.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalog, null);
            this.profileCatalog.ButtonText = "Perfil";
            this.profileCatalog.Location = new System.Drawing.Point(17, 124);
            this.profileCatalog.Name = "profileCatalog";
            this.profileCatalog.SelectedProfile = "";
            this.profileCatalog.Size = new System.Drawing.Size(88, 27);
            this.profileCatalog.TabIndex = 4;
            this.profileCatalog.SelectClicked += new System.EventHandler(this.profileCatalogSelectClicked);
            this.profileCatalog.SelectionDone += new System.EventHandler(this.profileCatalogSelectionDone);
            // 
            // saveLoad
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad, null);
            this.saveLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad, null);
            this.saveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad.HelpKeyword = "";
            this.saveLoad.HelpUrl = "";
            this.saveLoad.Location = new System.Drawing.Point(3, 3);
            this.saveLoad.Name = "saveLoad";
            this.saveLoad.SaveAsText = "";
            this.saveLoad.Size = new System.Drawing.Size(528, 43);
            this.saveLoad.TabIndex = 0;
            this.saveLoad.UserDefinedHelpFilePath = null;
            // 
            // buttonCreateBeam
            // 
            this.structuresExtender.SetAttributeName(this.buttonCreateBeam, null);
            this.structuresExtender.SetAttributeTypeName(this.buttonCreateBeam, null);
            this.structuresExtender.SetBindPropertyName(this.buttonCreateBeam, null);
            this.buttonCreateBeam.Location = new System.Drawing.Point(17, 227);
            this.buttonCreateBeam.Name = "buttonCreateBeam";
            this.buttonCreateBeam.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateBeam.TabIndex = 10;
            this.buttonCreateBeam.Text = "Crear viga";
            this.buttonCreateBeam.UseVisualStyleBackColor = true;
            this.buttonCreateBeam.Click += new System.EventHandler(this.buttonCreateBeam_Click);
            // 
            // OkApplyModifyGetOnOffCancel
            // 
            this.structuresExtender.SetAttributeName(this.OkApplyModifyGetOnOffCancel, null);
            this.structuresExtender.SetAttributeTypeName(this.OkApplyModifyGetOnOffCancel, null);
            this.structuresExtender.SetBindPropertyName(this.OkApplyModifyGetOnOffCancel, null);
            this.OkApplyModifyGetOnOffCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OkApplyModifyGetOnOffCancel.Location = new System.Drawing.Point(3, 382);
            this.OkApplyModifyGetOnOffCancel.Name = "OkApplyModifyGetOnOffCancel";
            this.OkApplyModifyGetOnOffCancel.Size = new System.Drawing.Size(528, 29);
            this.OkApplyModifyGetOnOffCancel.TabIndex = 19;
            this.OkApplyModifyGetOnOffCancel.OkClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OkClicked);
            this.OkApplyModifyGetOnOffCancel.ApplyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ApplyClicked);
            this.OkApplyModifyGetOnOffCancel.ModifyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ModifyClicked);
            this.OkApplyModifyGetOnOffCancel.GetClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_GetClicked);
            this.OkApplyModifyGetOnOffCancel.OnOffClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OnOffClicked);
            this.OkApplyModifyGetOnOffCancel.CancelClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_CancelClicked);
            // 
            // MainForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(534, 414);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Model Plug-in";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ParametersTabPage.ResumeLayout(false);
            this.ParametersTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ParametersTabPage;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private Tekla.Structures.Dialog.UIControls.MaterialCatalog materialCatalog;
        private System.Windows.Forms.TextBox textBoxProfile;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel OkApplyModifyGetOnOffCancel;
        private System.Windows.Forms.Button buttonCreateBeam;
    }
}