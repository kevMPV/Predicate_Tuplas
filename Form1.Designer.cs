namespace predicate_tuplas
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
            btnTuplas = new Button();
            btnPredicate = new Button();
            btnTuplasYPredicate = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtNumero = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTuplas
            // 
            btnTuplas.BackColor = Color.Yellow;
            btnTuplas.FlatStyle = FlatStyle.Flat;
            btnTuplas.Font = new Font("Segoe UI", 15F);
            btnTuplas.Location = new Point(45, 37);
            btnTuplas.Name = "btnTuplas";
            btnTuplas.Size = new Size(172, 65);
            btnTuplas.TabIndex = 0;
            btnTuplas.Text = "Tuplas";
            btnTuplas.UseVisualStyleBackColor = false;
            btnTuplas.Click += btnTuplas_Click;
            // 
            // btnPredicate
            // 
            btnPredicate.BackColor = Color.Yellow;
            btnPredicate.FlatStyle = FlatStyle.Flat;
            btnPredicate.Font = new Font("Segoe UI", 15F);
            btnPredicate.Location = new Point(42, 139);
            btnPredicate.Name = "btnPredicate";
            btnPredicate.Size = new Size(172, 65);
            btnPredicate.TabIndex = 1;
            btnPredicate.Text = "Predicate";
            btnPredicate.UseVisualStyleBackColor = false;
            btnPredicate.Click += btnPredicate_Click;
            // 
            // btnTuplasYPredicate
            // 
            btnTuplasYPredicate.BackColor = Color.Yellow;
            btnTuplasYPredicate.FlatStyle = FlatStyle.Flat;
            btnTuplasYPredicate.Font = new Font("Segoe UI", 15F);
            btnTuplasYPredicate.Location = new Point(45, 176);
            btnTuplasYPredicate.Name = "btnTuplasYPredicate";
            btnTuplasYPredicate.Size = new Size(172, 65);
            btnTuplasYPredicate.TabIndex = 2;
            btnTuplasYPredicate.Text = "Tupla y Predicate";
            btnTuplasYPredicate.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(btnPredicate);
            groupBox1.Location = new Point(241, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 223);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 29);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresar Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(77, 68);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 298);
            Controls.Add(groupBox1);
            Controls.Add(btnTuplasYPredicate);
            Controls.Add(btnTuplas);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTuplas;
        private Button btnPredicate;
        private Button btnTuplasYPredicate;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNumero;
    }
}
