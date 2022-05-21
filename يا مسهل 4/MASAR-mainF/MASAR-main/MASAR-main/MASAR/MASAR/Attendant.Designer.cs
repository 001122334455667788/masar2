namespace MASAR
{
    partial class Attendant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendant));
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.airline_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(197, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(576, 39);
            this.label10.TabIndex = 52;
            this.label10.Text = "Add New Attendant On The System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(237, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 39);
            this.label2.TabIndex = 51;
            this.label2.Text = "MASAR Airline Management";
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.White;
            this.salary.Location = new System.Drawing.Point(639, 207);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(171, 27);
            this.salary.TabIndex = 54;
            this.salary.TextChanged += new System.EventHandler(this.salary_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(163, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 27);
            this.label8.TabIndex = 53;
            this.label8.Text = "Add Salary";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(363, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 58);
            this.button1.TabIndex = 55;
            this.button1.Text = "Submit As Attendant";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // airline_id
            // 
            this.airline_id.BackColor = System.Drawing.Color.White;
            this.airline_id.Location = new System.Drawing.Point(639, 258);
            this.airline_id.Name = "airline_id";
            this.airline_id.Size = new System.Drawing.Size(171, 27);
            this.airline_id.TabIndex = 57;
            this.airline_id.TextChanged += new System.EventHandler(this.airline_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "What Is His AirLine ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(163, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 58;
            this.label3.Text = "per_id";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(639, 316);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(171, 27);
            this.id.TabIndex = 59;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Attendant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 548);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.airline_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendant";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Attendant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Label label2;
        private TextBox salary;
        private Label label8;
        private Button button1;
        private TextBox airline_id;
        private Label label1;
        private Label label3;
        private TextBox id;
    }
}