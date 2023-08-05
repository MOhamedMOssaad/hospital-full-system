
namespace HospitalDB
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDBDataSet = new HospitalDB.HospitalDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoctorsTableAdapter = new HospitalDB.HospitalDBDataSetTableAdapters.DoctorsTableAdapter();
            this.NursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NursesTableAdapter = new HospitalDB.HospitalDBDataSetTableAdapters.NursesTableAdapter();
            this.DepartmentTableAdapter = new HospitalDB.HospitalDBDataSetTableAdapters.DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentBindingSource
            // 
            this.DepartmentBindingSource.DataMember = "Department";
            this.DepartmentBindingSource.DataSource = this.HospitalDBDataSet;
            // 
            // HospitalDBDataSet
            // 
            this.HospitalDBDataSet.DataSetName = "HospitalDBDataSet";
            this.HospitalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DoctorsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalDB.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(709, 345);
            this.reportViewer1.TabIndex = 0;
            // 
            // DoctorsBindingSource
            // 
            this.DoctorsBindingSource.DataMember = "Doctors";
            this.DoctorsBindingSource.DataSource = this.HospitalDBDataSet;
            // 
            // DoctorsTableAdapter
            // 
            this.DoctorsTableAdapter.ClearBeforeFill = true;
            // 
            // NursesBindingSource
            // 
            this.NursesBindingSource.DataMember = "Nurses";
            this.NursesBindingSource.DataSource = this.HospitalDBDataSet;
            // 
            // NursesTableAdapter
            // 
            this.NursesTableAdapter.ClearBeforeFill = true;
            // 
            // DepartmentTableAdapter
            // 
            this.DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DoctorsBindingSource;
        private HospitalDBDataSet HospitalDBDataSet;
        private HospitalDBDataSetTableAdapters.DoctorsTableAdapter DoctorsTableAdapter;
        private System.Windows.Forms.BindingSource NursesBindingSource;
        private HospitalDBDataSetTableAdapters.NursesTableAdapter NursesTableAdapter;
        private System.Windows.Forms.BindingSource DepartmentBindingSource;
        private HospitalDBDataSetTableAdapters.DepartmentTableAdapter DepartmentTableAdapter;
    }
}