namespace Airport
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.airportDataSet = new Airport.AirportDataSet();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new Airport.AirportDataSetTableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager = new Airport.AirportDataSetTableAdapters.TableAdapterManager();
            this.rEGISTERATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEGISTERATIONTableAdapter = new Airport.AirportDataSetTableAdapters.REGISTERATIONTableAdapter();
            this.rEGISTERATIONDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERATIONDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.airportDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.AIRCRAFTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.DRIVED_BYTableAdapter = null;
            this.tableAdapterManager.FLIGHTTableAdapter = null;
            this.tableAdapterManager.MODELTableAdapter = null;
            this.tableAdapterManager.PILOTTableAdapter = null;
            this.tableAdapterManager.PUBLICTableAdapter = null;
            this.tableAdapterManager.REGISTERATIONTableAdapter = null;
            this.tableAdapterManager.SPECIALTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.UPDATE_ANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Airport.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rEGISTERATIONBindingSource
            // 
            this.rEGISTERATIONBindingSource.DataMember = "REGISTERATION";
            this.rEGISTERATIONBindingSource.DataSource = this.airportDataSet;
            // 
            // rEGISTERATIONTableAdapter
            // 
            this.rEGISTERATIONTableAdapter.ClearBeforeFill = true;
            // 
            // rEGISTERATIONDataGridView
            // 
            this.rEGISTERATIONDataGridView.AutoGenerateColumns = false;
            this.rEGISTERATIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rEGISTERATIONDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.rEGISTERATIONDataGridView.DataSource = this.rEGISTERATIONBindingSource;
            this.rEGISTERATIONDataGridView.Location = new System.Drawing.Point(3, 5);
            this.rEGISTERATIONDataGridView.Name = "rEGISTERATIONDataGridView";
            this.rEGISTERATIONDataGridView.Size = new System.Drawing.Size(1219, 542);
            this.rEGISTERATIONDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SSN";
            this.dataGridViewTextBoxColumn1.HeaderText = "SSN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ADMINID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ADMINID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 559);
            this.Controls.Add(this.rEGISTERATIONDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERATIONDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private AirportDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource rEGISTERATIONBindingSource;
        private AirportDataSetTableAdapters.REGISTERATIONTableAdapter rEGISTERATIONTableAdapter;
        private System.Windows.Forms.DataGridView rEGISTERATIONDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}