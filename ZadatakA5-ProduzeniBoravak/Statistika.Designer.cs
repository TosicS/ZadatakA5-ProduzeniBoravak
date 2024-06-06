namespace ZadatakA5_ProduzeniBoravak
{
    partial class Statistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrikaziF2 = new System.Windows.Forms.Button();
            this.buttonIzadji = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonPrikaziF2
            // 
            this.buttonPrikaziF2.Location = new System.Drawing.Point(13, 368);
            this.buttonPrikaziF2.Name = "buttonPrikaziF2";
            this.buttonPrikaziF2.Size = new System.Drawing.Size(107, 44);
            this.buttonPrikaziF2.TabIndex = 1;
            this.buttonPrikaziF2.Text = "Prikazi";
            this.buttonPrikaziF2.UseVisualStyleBackColor = true;
            this.buttonPrikaziF2.Click += new System.EventHandler(this.buttonPrikaziF2_Click);
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.Location = new System.Drawing.Point(204, 368);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Size = new System.Drawing.Size(107, 44);
            this.buttonIzadji.TabIndex = 2;
            this.buttonIzadji.Text = "Izadji";
            this.buttonIzadji.UseVisualStyleBackColor = true;
            this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(405, 13);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(365, 399);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonIzadji);
            this.Controls.Add(this.buttonPrikaziF2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Statistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Statistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPrikaziF2;
        private System.Windows.Forms.Button buttonIzadji;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}