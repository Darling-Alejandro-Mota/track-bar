namespace track__bar
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
            label1 = new Label();
            lbl_Tamano = new Label();
            trb_Tamano = new TrackBar();
            lbl_Texto = new Label();
            ((System.ComponentModel.ISupportInitialize)trb_Tamano).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Engravers MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 29);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 9;
            label1.Text = "TAMAÑO";
            // 
            // lbl_Tamano
            // 
            lbl_Tamano.AutoSize = true;
            lbl_Tamano.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Tamano.Location = new Point(211, 179);
            lbl_Tamano.Name = "lbl_Tamano";
            lbl_Tamano.Size = new Size(73, 22);
            lbl_Tamano.TabIndex = 7;
            lbl_Tamano.Text = "Grosor";
            // 
            // trb_Tamano
            // 
            trb_Tamano.Location = new Point(160, 131);
            trb_Tamano.Name = "trb_Tamano";
            trb_Tamano.Size = new Size(243, 45);
            trb_Tamano.TabIndex = 6;
            trb_Tamano.Scroll += trb_Tamano_Scroll;
            // 
            // lbl_Texto
            // 
            lbl_Texto.AutoSize = true;
            lbl_Texto.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbl_Texto.Location = new Point(95, 131);
            lbl_Texto.Name = "lbl_Texto";
            lbl_Texto.Size = new Size(23, 22);
            lbl_Texto.TabIndex = 11;
            lbl_Texto.Text = "A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(574, 332);
            Controls.Add(lbl_Texto);
            Controls.Add(label1);
            Controls.Add(lbl_Tamano);
            Controls.Add(trb_Tamano);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trb_Tamano).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Tamano;
        private TrackBar trb_Tamano;
        private Label lbl_Texto;
    }
}
