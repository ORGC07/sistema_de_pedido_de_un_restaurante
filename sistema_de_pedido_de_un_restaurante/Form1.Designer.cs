namespace sistema_de_pedido_de_un_restaurante
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ramen = new System.Windows.Forms.Button();
            this.pastelon = new System.Windows.Forms.Button();
            this.Mofongo = new System.Windows.Forms.Button();
            this.cheesecake = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.canelones = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ramen
            // 
            this.Ramen.Image = global::sistema_de_pedido_de_un_restaurante.Properties.Resources.ramen_adobe_m1;
            this.Ramen.Location = new System.Drawing.Point(543, 222);
            this.Ramen.Name = "Ramen";
            this.Ramen.Size = new System.Drawing.Size(203, 188);
            this.Ramen.TabIndex = 0;
            this.Ramen.UseVisualStyleBackColor = true;
            this.Ramen.Click += new System.EventHandler(this.Ramen_Click);
            // 
            // pastelon
            // 
            this.pastelon.Image = global::sistema_de_pedido_de_un_restaurante.Properties.Resources.pastelon_platanos_maduros_1_074_1;
            this.pastelon.Location = new System.Drawing.Point(332, 37);
            this.pastelon.Name = "pastelon";
            this.pastelon.Size = new System.Drawing.Size(205, 145);
            this.pastelon.TabIndex = 1;
            this.pastelon.UseVisualStyleBackColor = true;
            this.pastelon.Click += new System.EventHandler(this.pastelon_Click);
            // 
            // Mofongo
            // 
            this.Mofongo.Image = global::sistema_de_pedido_de_un_restaurante.Properties.Resources.MofongoPower;
            this.Mofongo.Location = new System.Drawing.Point(545, 42);
            this.Mofongo.Name = "Mofongo";
            this.Mofongo.Size = new System.Drawing.Size(201, 179);
            this.Mofongo.TabIndex = 2;
            this.Mofongo.Text = "button3";
            this.Mofongo.UseVisualStyleBackColor = true;
            this.Mofongo.Click += new System.EventHandler(this.Mofongo_Click);
            // 
            // cheesecake
            // 
            this.cheesecake.Image = global::sistema_de_pedido_de_un_restaurante.Properties.Resources.chikey_de_dulceleche;
            this.cheesecake.Location = new System.Drawing.Point(329, 310);
            this.cheesecake.Name = "cheesecake";
            this.cheesecake.Size = new System.Drawing.Size(208, 115);
            this.cheesecake.TabIndex = 3;
            this.cheesecake.UseVisualStyleBackColor = true;
            this.cheesecake.Click += new System.EventHandler(this.cheesecake_Click);
            // 
            // button5
            // 
            this.button5.Image = global::sistema_de_pedido_de_un_restaurante.Properties.Resources.helado1;
            this.button5.Location = new System.Drawing.Point(28, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(295, 388);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // canelones
            // 
            this.canelones.Image = global::sistema_de_pedido_de_un_restaurante.Properties.Resources.canewlones1;
            this.canelones.Location = new System.Drawing.Point(329, 188);
            this.canelones.Name = "canelones";
            this.canelones.Size = new System.Drawing.Size(201, 116);
            this.canelones.TabIndex = 5;
            this.canelones.UseVisualStyleBackColor = true;
            this.canelones.Click += new System.EventHandler(this.canelones_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciones su orden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canelones);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cheesecake);
            this.Controls.Add(this.Mofongo);
            this.Controls.Add(this.pastelon);
            this.Controls.Add(this.Ramen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Ramen;
        private Button pastelon;
        private Button Mofongo;
        private Button cheesecake;
        private Button button5;
        private Button canelones;
        private ImageList imageList1;
        private Label label1;
    }
}