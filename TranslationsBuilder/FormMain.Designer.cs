﻿
using System.Drawing;
using System.Windows.Forms;

namespace TranslationsBuilder {
  partial class FormMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.gridTranslations = new System.Windows.Forms.DataGridView();
      this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
      this.groupDefaultCulture = new System.Windows.Forms.GroupBox();
      this.lblDefaultCultureNameLabel = new System.Windows.Forms.Label();
      this.btnPopulateDefaultCultureTranslations = new System.Windows.Forms.Button();
      this.txtDefaultCulture = new System.Windows.Forms.TextBox();
      this.groupDatasetProperties = new System.Windows.Forms.GroupBox();
      this.txtEstimatedSize = new System.Windows.Forms.TextBox();
      this.lblEstimatedSize = new System.Windows.Forms.Label();
      this.txtCompatibilityLevel = new System.Windows.Forms.TextBox();
      this.lblCompatibilityLevel = new System.Windows.Forms.Label();
      this.txtDataset = new System.Windows.Forms.TextBox();
      this.txtServer = new System.Windows.Forms.TextBox();
      this.lblDataset = new System.Windows.Forms.Label();
      this.lblServer = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.grpImportExportTranslations = new System.Windows.Forms.GroupBox();
      this.listLanguageForTransation = new System.Windows.Forms.ComboBox();
      this.btnExportTranslations = new System.Windows.Forms.Button();
      this.btnImportTranslations = new System.Windows.Forms.Button();
      this.btnExportTranslationsSheet = new System.Windows.Forms.Button();
      this.grpMachineTranslations = new System.Windows.Forms.GroupBox();
      this.btnGenenrateMachineTranslations = new System.Windows.Forms.Button();
      this.listCultureToPopulate = new System.Windows.Forms.ComboBox();
      this.grpSecondaryCultures = new System.Windows.Forms.GroupBox();
      this.addSecondaryCulture = new System.Windows.Forms.Button();
      this.listSecondaryCultures = new System.Windows.Forms.ListBox();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.menuSetDatasetName = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuConfigureSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.btnGenenrateAllMachineTranslations = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gridTranslations)).BeginInit();
      this.groupDefaultCulture.SuspendLayout();
      this.groupDatasetProperties.SuspendLayout();
      this.panel2.SuspendLayout();
      this.grpImportExportTranslations.SuspendLayout();
      this.grpMachineTranslations.SuspendLayout();
      this.grpSecondaryCultures.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // gridTranslations
      // 
      this.gridTranslations.AllowUserToAddRows = false;
      this.gridTranslations.AllowUserToDeleteRows = false;
      this.gridTranslations.AllowUserToResizeColumns = false;
      this.gridTranslations.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gridTranslations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.gridTranslations.ColumnHeadersHeight = 29;
      this.gridTranslations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.gridTranslations.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridTranslations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.gridTranslations.EnableHeadersVisualStyles = false;
      this.gridTranslations.Location = new System.Drawing.Point(0, 237);
      this.gridTranslations.MultiSelect = false;
      this.gridTranslations.Name = "gridTranslations";
      this.gridTranslations.ReadOnly = true;
      this.gridTranslations.RowHeadersWidth = 24;
      this.gridTranslations.RowTemplate.Height = 28;
      this.gridTranslations.Size = new System.Drawing.Size(1416, 502);
      this.gridTranslations.TabIndex = 0;
      this.gridTranslations.TabStop = false;
      // 
      // dialogOpenFile
      // 
      this.dialogOpenFile.FileName = "openFileDialog1";
      // 
      // groupDefaultCulture
      // 
      this.groupDefaultCulture.Controls.Add(this.lblDefaultCultureNameLabel);
      this.groupDefaultCulture.Controls.Add(this.btnPopulateDefaultCultureTranslations);
      this.groupDefaultCulture.Controls.Add(this.txtDefaultCulture);
      this.groupDefaultCulture.Location = new System.Drawing.Point(464, 37);
      this.groupDefaultCulture.Name = "groupDefaultCulture";
      this.groupDefaultCulture.Size = new System.Drawing.Size(224, 189);
      this.groupDefaultCulture.TabIndex = 1;
      this.groupDefaultCulture.TabStop = false;
      this.groupDefaultCulture.Text = "Default Culture";
      // 
      // lblDefaultCultureNameLabel
      // 
      this.lblDefaultCultureNameLabel.AutoSize = true;
      this.lblDefaultCultureNameLabel.Location = new System.Drawing.Point(14, 35);
      this.lblDefaultCultureNameLabel.Name = "lblDefaultCultureNameLabel";
      this.lblDefaultCultureNameLabel.Size = new System.Drawing.Size(52, 20);
      this.lblDefaultCultureNameLabel.TabIndex = 31;
      this.lblDefaultCultureNameLabel.Text = "Name:";
      // 
      // btnPopulateDefaultCultureTranslations
      // 
      this.btnPopulateDefaultCultureTranslations.Location = new System.Drawing.Point(11, 69);
      this.btnPopulateDefaultCultureTranslations.Name = "btnPopulateDefaultCultureTranslations";
      this.btnPopulateDefaultCultureTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnPopulateDefaultCultureTranslations.TabIndex = 1;
      this.btnPopulateDefaultCultureTranslations.Text = "Populate Translations";
      this.btnPopulateDefaultCultureTranslations.UseVisualStyleBackColor = true;
      this.btnPopulateDefaultCultureTranslations.Click += new System.EventHandler(this.PopulateDefaultCultureTranslations);
      // 
      // txtDefaultCulture
      // 
      this.txtDefaultCulture.Location = new System.Drawing.Point(69, 29);
      this.txtDefaultCulture.Name = "txtDefaultCulture";
      this.txtDefaultCulture.Size = new System.Drawing.Size(143, 27);
      this.txtDefaultCulture.TabIndex = 0;
      this.txtDefaultCulture.TabStop = false;
      // 
      // groupDatasetProperties
      // 
      this.groupDatasetProperties.Controls.Add(this.txtEstimatedSize);
      this.groupDatasetProperties.Controls.Add(this.lblEstimatedSize);
      this.groupDatasetProperties.Controls.Add(this.txtCompatibilityLevel);
      this.groupDatasetProperties.Controls.Add(this.lblCompatibilityLevel);
      this.groupDatasetProperties.Controls.Add(this.txtDataset);
      this.groupDatasetProperties.Controls.Add(this.txtServer);
      this.groupDatasetProperties.Controls.Add(this.lblDataset);
      this.groupDatasetProperties.Controls.Add(this.lblServer);
      this.groupDatasetProperties.Location = new System.Drawing.Point(9, 37);
      this.groupDatasetProperties.Name = "groupDatasetProperties";
      this.groupDatasetProperties.Size = new System.Drawing.Size(440, 188);
      this.groupDatasetProperties.TabIndex = 0;
      this.groupDatasetProperties.TabStop = false;
      this.groupDatasetProperties.Text = "Dataset Properties";
      // 
      // txtEstimatedSize
      // 
      this.txtEstimatedSize.Location = new System.Drawing.Point(121, 141);
      this.txtEstimatedSize.Name = "txtEstimatedSize";
      this.txtEstimatedSize.ReadOnly = true;
      this.txtEstimatedSize.Size = new System.Drawing.Size(307, 27);
      this.txtEstimatedSize.TabIndex = 26;
      this.txtEstimatedSize.TabStop = false;
      // 
      // lblEstimatedSize
      // 
      this.lblEstimatedSize.AutoSize = true;
      this.lblEstimatedSize.Location = new System.Drawing.Point(11, 147);
      this.lblEstimatedSize.Name = "lblEstimatedSize";
      this.lblEstimatedSize.Size = new System.Drawing.Size(109, 20);
      this.lblEstimatedSize.TabIndex = 25;
      this.lblEstimatedSize.Text = "Estimated Size:";
      this.lblEstimatedSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtCompatibilityLevel
      // 
      this.txtCompatibilityLevel.Location = new System.Drawing.Point(121, 104);
      this.txtCompatibilityLevel.Name = "txtCompatibilityLevel";
      this.txtCompatibilityLevel.ReadOnly = true;
      this.txtCompatibilityLevel.Size = new System.Drawing.Size(307, 27);
      this.txtCompatibilityLevel.TabIndex = 22;
      this.txtCompatibilityLevel.TabStop = false;
      // 
      // lblCompatibilityLevel
      // 
      this.lblCompatibilityLevel.AutoSize = true;
      this.lblCompatibilityLevel.Location = new System.Drawing.Point(17, 109);
      this.lblCompatibilityLevel.Name = "lblCompatibilityLevel";
      this.lblCompatibilityLevel.Size = new System.Drawing.Size(103, 20);
      this.lblCompatibilityLevel.TabIndex = 21;
      this.lblCompatibilityLevel.Text = "Compat Level:";
      this.lblCompatibilityLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtDataset
      // 
      this.txtDataset.Location = new System.Drawing.Point(121, 67);
      this.txtDataset.Name = "txtDataset";
      this.txtDataset.ReadOnly = true;
      this.txtDataset.Size = new System.Drawing.Size(307, 27);
      this.txtDataset.TabIndex = 20;
      this.txtDataset.TabStop = false;
      // 
      // txtServer
      // 
      this.txtServer.Location = new System.Drawing.Point(121, 29);
      this.txtServer.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.txtServer.Name = "txtServer";
      this.txtServer.ReadOnly = true;
      this.txtServer.Size = new System.Drawing.Size(307, 27);
      this.txtServer.TabIndex = 0;
      this.txtServer.TabStop = false;
      // 
      // lblDataset
      // 
      this.lblDataset.AutoSize = true;
      this.lblDataset.Location = new System.Drawing.Point(50, 73);
      this.lblDataset.Name = "lblDataset";
      this.lblDataset.Size = new System.Drawing.Size(63, 20);
      this.lblDataset.TabIndex = 18;
      this.lblDataset.Text = "Dataset:";
      this.lblDataset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblServer
      // 
      this.lblServer.AutoSize = true;
      this.lblServer.Location = new System.Drawing.Point(64, 37);
      this.lblServer.Name = "lblServer";
      this.lblServer.Size = new System.Drawing.Size(53, 20);
      this.lblServer.TabIndex = 17;
      this.lblServer.Text = "Server:";
      this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel2.Controls.Add(this.grpImportExportTranslations);
      this.panel2.Controls.Add(this.grpMachineTranslations);
      this.panel2.Controls.Add(this.grpSecondaryCultures);
      this.panel2.Controls.Add(this.groupDatasetProperties);
      this.panel2.Controls.Add(this.groupDefaultCulture);
      this.panel2.Controls.Add(this.menuStrip);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1416, 237);
      this.panel2.TabIndex = 8;
      // 
      // grpImportExportTranslations
      // 
      this.grpImportExportTranslations.Controls.Add(this.listLanguageForTransation);
      this.grpImportExportTranslations.Controls.Add(this.btnExportTranslations);
      this.grpImportExportTranslations.Controls.Add(this.btnImportTranslations);
      this.grpImportExportTranslations.Controls.Add(this.btnExportTranslationsSheet);
      this.grpImportExportTranslations.Location = new System.Drawing.Point(938, 35);
      this.grpImportExportTranslations.Name = "grpImportExportTranslations";
      this.grpImportExportTranslations.Size = new System.Drawing.Size(224, 191);
      this.grpImportExportTranslations.TabIndex = 4;
      this.grpImportExportTranslations.TabStop = false;
      this.grpImportExportTranslations.Text = "Export/Import Translations";
      // 
      // listLanguageForTransation
      // 
      this.listLanguageForTransation.BackColor = System.Drawing.SystemColors.Window;
      this.listLanguageForTransation.FormattingEnabled = true;
      this.listLanguageForTransation.Location = new System.Drawing.Point(13, 65);
      this.listLanguageForTransation.Name = "listLanguageForTransation";
      this.listLanguageForTransation.Size = new System.Drawing.Size(198, 28);
      this.listLanguageForTransation.TabIndex = 6;
      // 
      // btnExportTranslations
      // 
      this.btnExportTranslations.Location = new System.Drawing.Point(11, 99);
      this.btnExportTranslations.Name = "btnExportTranslations";
      this.btnExportTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnExportTranslations.TabIndex = 7;
      this.btnExportTranslations.Text = "Export All Translations";
      this.btnExportTranslations.UseVisualStyleBackColor = true;
      this.btnExportTranslations.Click += new System.EventHandler(this.ExportTranslations);
      // 
      // btnImportTranslations
      // 
      this.btnImportTranslations.Location = new System.Drawing.Point(11, 141);
      this.btnImportTranslations.Name = "btnImportTranslations";
      this.btnImportTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnImportTranslations.TabIndex = 8;
      this.btnImportTranslations.Text = "Import Translations";
      this.btnImportTranslations.UseVisualStyleBackColor = true;
      this.btnImportTranslations.Click += new System.EventHandler(this.ImportTranslations);
      // 
      // btnExportTranslationsSheet
      // 
      this.btnExportTranslationsSheet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnExportTranslationsSheet.BackColor = System.Drawing.SystemColors.ControlLight;
      this.btnExportTranslationsSheet.Location = new System.Drawing.Point(11, 24);
      this.btnExportTranslationsSheet.Name = "btnExportTranslationsSheet";
      this.btnExportTranslationsSheet.Size = new System.Drawing.Size(200, 36);
      this.btnExportTranslationsSheet.TabIndex = 5;
      this.btnExportTranslationsSheet.Text = "Export Translations Sheet";
      this.btnExportTranslationsSheet.UseVisualStyleBackColor = false;
      this.btnExportTranslationsSheet.Click += new System.EventHandler(this.ExportTranslationsSheet);
      // 
      // grpMachineTranslations
      // 
      this.grpMachineTranslations.Controls.Add(this.btnGenenrateAllMachineTranslations);
      this.grpMachineTranslations.Controls.Add(this.btnGenenrateMachineTranslations);
      this.grpMachineTranslations.Controls.Add(this.listCultureToPopulate);
      this.grpMachineTranslations.Location = new System.Drawing.Point(1175, 35);
      this.grpMachineTranslations.Name = "grpMachineTranslations";
      this.grpMachineTranslations.Size = new System.Drawing.Size(224, 192);
      this.grpMachineTranslations.TabIndex = 9;
      this.grpMachineTranslations.TabStop = false;
      this.grpMachineTranslations.Text = "Machine Translations";
      // 
      // btnGenenrateMachineTranslations
      // 
      this.btnGenenrateMachineTranslations.BackColor = System.Drawing.SystemColors.ControlLight;
      this.btnGenenrateMachineTranslations.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnGenenrateMachineTranslations.Location = new System.Drawing.Point(11, 27);
      this.btnGenenrateMachineTranslations.Name = "btnGenenrateMachineTranslations";
      this.btnGenenrateMachineTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnGenenrateMachineTranslations.TabIndex = 10;
      this.btnGenenrateMachineTranslations.Text = "Genenrate Translations";
      this.btnGenenrateMachineTranslations.UseVisualStyleBackColor = false;
      this.btnGenenrateMachineTranslations.Click += new System.EventHandler(this.GenenrateMachineTranslations);
      // 
      // listCultureToPopulate
      // 
      this.listCultureToPopulate.FormattingEnabled = true;
      this.listCultureToPopulate.Location = new System.Drawing.Point(11, 69);
      this.listCultureToPopulate.Name = "listCultureToPopulate";
      this.listCultureToPopulate.Size = new System.Drawing.Size(201, 28);
      this.listCultureToPopulate.TabIndex = 11;
      // 
      // grpSecondaryCultures
      // 
      this.grpSecondaryCultures.Controls.Add(this.addSecondaryCulture);
      this.grpSecondaryCultures.Controls.Add(this.listSecondaryCultures);
      this.grpSecondaryCultures.Location = new System.Drawing.Point(702, 36);
      this.grpSecondaryCultures.Name = "grpSecondaryCultures";
      this.grpSecondaryCultures.Size = new System.Drawing.Size(224, 189);
      this.grpSecondaryCultures.TabIndex = 2;
      this.grpSecondaryCultures.TabStop = false;
      this.grpSecondaryCultures.Text = "Secondary Cultures";
      // 
      // addSecondaryCulture
      // 
      this.addSecondaryCulture.Location = new System.Drawing.Point(8, 27);
      this.addSecondaryCulture.Name = "addSecondaryCulture";
      this.addSecondaryCulture.Size = new System.Drawing.Size(200, 36);
      this.addSecondaryCulture.TabIndex = 3;
      this.addSecondaryCulture.Text = "Add Culture";
      this.addSecondaryCulture.UseVisualStyleBackColor = true;
      this.addSecondaryCulture.Click += new System.EventHandler(this.AddSecondaryCulture);
      // 
      // listSecondaryCultures
      // 
      this.listSecondaryCultures.FormattingEnabled = true;
      this.listSecondaryCultures.ItemHeight = 20;
      this.listSecondaryCultures.Location = new System.Drawing.Point(9, 69);
      this.listSecondaryCultures.Name = "listSecondaryCultures";
      this.listSecondaryCultures.Size = new System.Drawing.Size(201, 104);
      this.listSecondaryCultures.TabIndex = 0;
      this.listSecondaryCultures.TabStop = false;
      this.listSecondaryCultures.UseTabStops = false;
      // 
      // menuStrip
      // 
      this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettings});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
      this.menuStrip.Size = new System.Drawing.Size(1416, 30);
      this.menuStrip.TabIndex = 1;
      this.menuStrip.Text = "menuMain";
      // 
      // menuSettings
      // 
      this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetDatasetName,
            this.toolStripSeparator1,
            this.menuConfigureSettings});
      this.menuSettings.Name = "menuSettings";
      this.menuSettings.Size = new System.Drawing.Size(76, 24);
      this.menuSettings.Text = "Settings";
      // 
      // menuSetDatasetName
      // 
      this.menuSetDatasetName.Name = "menuSetDatasetName";
      this.menuSetDatasetName.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.menuSetDatasetName.Size = new System.Drawing.Size(321, 26);
      this.menuSetDatasetName.Text = "Set Dataset Friendly Name";
      this.menuSetDatasetName.Click += new System.EventHandler(this.SetDatasetName);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(318, 6);
      // 
      // menuConfigureSettings
      // 
      this.menuConfigureSettings.Name = "menuConfigureSettings";
      this.menuConfigureSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.menuConfigureSettings.Size = new System.Drawing.Size(321, 26);
      this.menuConfigureSettings.Text = "Configure Settings...";
      this.menuConfigureSettings.Click += new System.EventHandler(this.ConfigureSettings);
      // 
      // btnGenenrateAllMachineTranslations
      // 
      this.btnGenenrateAllMachineTranslations.Location = new System.Drawing.Point(11, 106);
      this.btnGenenrateAllMachineTranslations.Name = "btnGenenrateAllMachineTranslations";
      this.btnGenenrateAllMachineTranslations.Size = new System.Drawing.Size(200, 36);
      this.btnGenenrateAllMachineTranslations.TabIndex = 12;
      this.btnGenenrateAllMachineTranslations.Text = "Generate All Translation";
      this.btnGenenrateAllMachineTranslations.UseVisualStyleBackColor = true;
      this.btnGenenrateAllMachineTranslations.Click += new System.EventHandler(this.GenenrateAllMachineTranslations);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1416, 739);
      this.Controls.Add(this.gridTranslations);
      this.Controls.Add(this.panel2);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Translations Builder";
      this.Load += new System.EventHandler(this.onLoad);
      ((System.ComponentModel.ISupportInitialize)(this.gridTranslations)).EndInit();
      this.groupDefaultCulture.ResumeLayout(false);
      this.groupDefaultCulture.PerformLayout();
      this.groupDatasetProperties.ResumeLayout(false);
      this.groupDatasetProperties.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.grpImportExportTranslations.ResumeLayout(false);
      this.grpMachineTranslations.ResumeLayout(false);
      this.grpSecondaryCultures.ResumeLayout(false);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView gridTranslations;
    private OpenFileDialog dialogOpenFile;
    private GroupBox groupDefaultCulture;
    private Button btnPopulateDefaultCultureTranslations;
    private TextBox txtDefaultCulture;
    private GroupBox groupDatasetProperties;
    private Panel panel2;
    private Label lblDefaultCultureNameLabel;
    private GroupBox grpSecondaryCultures;
    private Button addSecondaryCulture;
    private ListBox listSecondaryCultures;
    private GroupBox grpMachineTranslations;
    private GroupBox grpImportExportTranslations;
    private Button btnExportTranslations;
    private Button btnImportTranslations;
    private Button btnExportTranslationsSheet;
    private ComboBox listLanguageForTransation;
    private ComboBox listCultureToPopulate;
    private Button btnGenenrateMachineTranslations;
    private TextBox txtEstimatedSize;
    private Label lblEstimatedSize;
    private TextBox txtCompatibilityLevel;
    private Label lblCompatibilityLevel;
    private TextBox txtDataset;
    private TextBox txtServer;
    private Label lblDataset;
    private Label lblServer;
    private MenuStrip menuStrip;
    private ToolStripMenuItem menuSettings;
    private ToolStripMenuItem menuConfigureSettings;
    private ToolStripMenuItem menuSetDatasetName;
    private ToolStripSeparator toolStripSeparator1;
    private Button btnGenenrateAllMachineTranslations;
  }
}

