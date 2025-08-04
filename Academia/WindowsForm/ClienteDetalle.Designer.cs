namespace WindowsForms
{
    partial class ClienteDetalle
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
            components = new System.ComponentModel.Container();
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            apellidoLabel = new Label();
            apellidoTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            fechaAltaLabel = new Label();
            fechaAltaTextBox = new TextBox();
            idLabel = new Label();
            idTextBox = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(150, 68);
            nombreTextBox.Margin = new Padding(2, 2, 2, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(125, 27);
            nombreTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(27, 68);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(273, 266);
            aceptarButton.Margin = new Padding(2, 2, 2, 2);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(92, 29);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(378, 266);
            cancelarButton.Margin = new Padding(2, 2, 2, 2);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(92, 29);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(27, 110);
            apellidoLabel.Margin = new Padding(2, 0, 2, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(66, 20);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(150, 110);
            apellidoTextBox.Margin = new Padding(2, 2, 2, 2);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(125, 27);
            apellidoTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(27, 158);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(150, 158);
            emailTextBox.Margin = new Padding(2, 2, 2, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(235, 27);
            emailTextBox.TabIndex = 2;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // fechaAltaLabel
            // 
            fechaAltaLabel.AutoSize = true;
            fechaAltaLabel.Location = new Point(27, 208);
            fechaAltaLabel.Margin = new Padding(2, 0, 2, 0);
            fechaAltaLabel.Name = "fechaAltaLabel";
            fechaAltaLabel.Size = new Size(78, 20);
            fechaAltaLabel.TabIndex = 9;
            fechaAltaLabel.Text = "Fecha Alta";
            // 
            // fechaAltaTextBox
            // 
            fechaAltaTextBox.Location = new Point(150, 208);
            fechaAltaTextBox.Margin = new Padding(2, 2, 2, 2);
            fechaAltaTextBox.Name = "fechaAltaTextBox";
            fechaAltaTextBox.ReadOnly = true;
            fechaAltaTextBox.Size = new Size(125, 27);
            fechaAltaTextBox.TabIndex = 0;
            fechaAltaTextBox.TabStop = false;
            fechaAltaTextBox.TextChanged += fechaAltaTextBox_TextChanged;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(27, 21);
            idLabel.Margin = new Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(22, 20);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(150, 21);
            idTextBox.Margin = new Padding(2, 2, 2, 2);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 0;
            idTextBox.TabStop = false;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 205);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            textBox1.TabStop = false;
            // 
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 315);
            Controls.Add(textBox1);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(fechaAltaLabel);
            Controls.Add(fechaAltaTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(apellidoLabel);
            Controls.Add(apellidoTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ClienteDetalle";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label apellidoLabel;
        private TextBox apellidoTextBox;
        private Label fechaAltaLabel;
        private TextBox fechaAltaTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label idLabel;
        private TextBox idTextBox;
        private TextBox textBox1;
    }
}