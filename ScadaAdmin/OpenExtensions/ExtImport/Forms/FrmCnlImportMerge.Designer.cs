﻿using System.ComponentModel;

namespace Scada.Admin.Extensions.ExtImport.Forms
{
	partial class FrmCnlImportMerge
	{
		//private DataGridView dataGridView;

		/// <summary> 
		/// 
		/// </summary>
		private IContainer components = null;

		/// <summary> 
		/// 
		/// </summary>
		/// <param name="disposing">
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants


		private void InitializeComponent()
		{
			label3 = new Label();
			dataGridView1 = new DataGridView();
			Column1Txt = new DataGridViewTextBoxColumn();
			ColumnChk = new DataGridViewCheckBoxColumn();
			fcnlName = new DataGridViewTextBoxColumn();
			fdataType = new DataGridViewTextBoxColumn();
			fcnlType = new DataGridViewTextBoxColumn();
			fTagCode = new DataGridViewTextBoxColumn();
			ColumnVide = new DataGridViewTextBoxColumn();
			Column2Chk = new DataGridViewCheckBoxColumn();
			cnlName = new DataGridViewTextBoxColumn();
			dataType = new DataGridViewTextBoxColumn();
			cnlType = new DataGridViewTextBoxColumn();
			tagCode = new DataGridViewTextBoxColumn();
			btnCancel = new Button();
			btnAdd = new Button();
			lblSource = new Label();
			lblDestination = new Label();
			saveFileDialog1 = new SaveFileDialog();
			((ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 27);
			label3.Name = "label3";
			label3.Size = new Size(0, 20);
			label3.TabIndex = 17;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1Txt, ColumnChk, fcnlName, fdataType, fcnlType, fTagCode, ColumnVide, Column2Chk, cnlName, dataType, cnlType, tagCode });
			dataGridView1.Location = new Point(11, 44);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 180;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(1671, 612);
			dataGridView1.TabIndex = 21;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// Column1Txt
			// 
			Column1Txt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Column1Txt.HeaderText = "Number";
			Column1Txt.MinimumWidth = 6;
			Column1Txt.Name = "Column1Txt";
			// 
			// ColumnChk
			// 
			ColumnChk.HeaderText = "";
			ColumnChk.MinimumWidth = 6;
			ColumnChk.Name = "ColumnChk";
			ColumnChk.Resizable = DataGridViewTriState.True;
			ColumnChk.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// fcnlName
			// 
			fcnlName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			fcnlName.HeaderText = "Name";
			fcnlName.MinimumWidth = 6;
			fcnlName.Name = "fcnlName";
			// 
			// fdataType
			// 
			fdataType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			fdataType.HeaderText = "Type";
			fdataType.MinimumWidth = 6;
			fdataType.Name = "fdataType";
			// 
			// fcnlType
			// 
			fcnlType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			fcnlType.HeaderText = "Channel Type";
			fcnlType.MinimumWidth = 6;
			fcnlType.Name = "fcnlType";
			// 
			// fTagCode
			// 
			fTagCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			fTagCode.HeaderText = "Tag Code";
			fTagCode.MinimumWidth = 6;
			fTagCode.Name = "fTagCode";
			// 
			// ColumnVide
			// 
			ColumnVide.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ColumnVide.HeaderText = "";
			ColumnVide.MinimumWidth = 6;
			ColumnVide.Name = "ColumnVide";
			// 
			// Column2Chk
			// 
			Column2Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Column2Chk.HeaderText = "";
			Column2Chk.MinimumWidth = 6;
			Column2Chk.Name = "Column2Chk";
			Column2Chk.Resizable = DataGridViewTriState.True;
			Column2Chk.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// cnlName
			// 
			cnlName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			cnlName.HeaderText = "Name";
			cnlName.MinimumWidth = 6;
			cnlName.Name = "cnlName";
			// 
			// dataType
			// 
			dataType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataType.HeaderText = "Type";
			dataType.MinimumWidth = 6;
			dataType.Name = "dataType";
			// 
			// cnlType
			// 
			cnlType.HeaderText = "Channel Type";
			cnlType.MinimumWidth = 6;
			cnlType.Name = "cnlType";
			// 
			// tagCode
			// 
			tagCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tagCode.HeaderText = "Tag Code";
			tagCode.MinimumWidth = 6;
			tagCode.Name = "tagCode";
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnCancel.Location = new Point(1547, 663);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(119, 35);
			btnCancel.TabIndex = 23;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAdd.Location = new Point(1408, 662);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(109, 35);
			btnAdd.TabIndex = 22;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click_1;
			// 
			// lblSource
			// 
			lblSource.BorderStyle = BorderStyle.FixedSingle;
			lblSource.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			lblSource.Location = new Point(442, -2);
			lblSource.Name = "lblSource";
			lblSource.Padding = new Padding(2, 3, 2, 3);
			lblSource.Size = new Size(143, 45);
			lblSource.TabIndex = 24;
			lblSource.Text = "From file";
			// 
			// lblDestination
			// 
			lblDestination.BorderStyle = BorderStyle.FixedSingle;
			lblDestination.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			lblDestination.Location = new Point(1188, 1);
			lblDestination.Name = "lblDestination";
			lblDestination.Padding = new Padding(2, 3, 2, 3);
			lblDestination.Size = new Size(177, 42);
			lblDestination.TabIndex = 25;
			lblDestination.Text = " From equipment";
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.Filter = "Fichiers XML (*.xml)|*.xml";
			saveFileDialog1.RestoreDirectory = true;
			// 
			// FrmCnlImportMerge
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(1694, 704);
			Controls.Add(lblDestination);
			Controls.Add(lblSource);
			Controls.Add(btnCancel);
			Controls.Add(btnAdd);
			Controls.Add(dataGridView1);
			Controls.Add(label3);
			Margin = new Padding(3, 4, 3, 4);
			MinimumSize = new Size(1440, 706);
			Name = "FrmCnlImportMerge";
			Text = "Merge";
			Load += FrmCnlMerge_Load;
			((ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label3;
		private DataGridView dataGridView1;
		private Button btnCancel;
		private Button btnAdd;
		private Label lblSource;
		private Label lblDestination;
		private SaveFileDialog saveFileDialog;
		private SaveFileDialog saveFileDialog1;
		private DataGridViewTextBoxColumn Column1Txt;
		private DataGridViewCheckBoxColumn ColumnChk;
		private DataGridViewTextBoxColumn fcnlName;
		private DataGridViewTextBoxColumn fdataType;
		private DataGridViewTextBoxColumn fcnlType;
		private DataGridViewTextBoxColumn fTagCode;
		private DataGridViewTextBoxColumn ColumnVide;
		private DataGridViewCheckBoxColumn Column2Chk;
		private DataGridViewTextBoxColumn cnlName;
		private DataGridViewTextBoxColumn dataType;
		private DataGridViewTextBoxColumn cnlType;
		private DataGridViewTextBoxColumn tagCode;
	}
}