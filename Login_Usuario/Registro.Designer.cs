namespace Login_Usuario
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar2 = new System.Windows.Forms.Button();
            this.user2 = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.cerrar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 33);
            this.panel1.TabIndex = 0;
            // 
            // cerrar2
            // 
            this.cerrar2.Image = ((System.Drawing.Image)(resources.GetObject("cerrar2.Image")));
            this.cerrar2.Location = new System.Drawing.Point(449, 7);
            this.cerrar2.Name = "cerrar2";
            this.cerrar2.Size = new System.Drawing.Size(25, 23);
            this.cerrar2.TabIndex = 1;
            this.cerrar2.UseVisualStyleBackColor = true;
            this.cerrar2.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // user2
            // 
            this.user2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2.Location = new System.Drawing.Point(41, 91);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(107, 21);
            this.user2.TabIndex = 3;
            this.user2.Text = "Usuario";
            this.user2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass2
            // 
            this.pass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass2.Location = new System.Drawing.Point(41, 159);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(122, 21);
            this.pass2.TabIndex = 5;
            this.pass2.Text = "Contraseña";
            this.pass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass2.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 162;
            this.lineShape2.X2 = 376;
            this.lineShape2.Y1 = 173;
            this.lineShape2.Y2 = 173;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(477, 320);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 161;
            this.lineShape1.X2 = 375;
            this.lineShape1.Y1 = 104;
            this.lineShape1.Y2 = 104;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Red;
            this.guardar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(161, 232);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(135, 36);
            this.guardar.TabIndex = 7;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 320);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrar2;
        private System.Windows.Forms.TextBox user2;
        private System.Windows.Forms.TextBox pass2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button guardar;
    }
}