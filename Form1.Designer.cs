namespace LR4CG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TurnXButton = new System.Windows.Forms.Button();
            this.TurnZButton = new System.Windows.Forms.Button();
            this.TurnYButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.numericUpDownMoveX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMoveY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.buttonScaling = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoveX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoveY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 516);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TurnXButton
            // 
            this.TurnXButton.Location = new System.Drawing.Point(537, 306);
            this.TurnXButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TurnXButton.Name = "TurnXButton";
            this.TurnXButton.Size = new System.Drawing.Size(96, 36);
            this.TurnXButton.TabIndex = 2;
            this.TurnXButton.Text = "Повернуть по X";
            this.TurnXButton.UseVisualStyleBackColor = true;
            this.TurnXButton.Click += new System.EventHandler(this.TurnXButton_Click);
            // 
            // TurnZButton
            // 
            this.TurnZButton.Location = new System.Drawing.Point(537, 388);
            this.TurnZButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TurnZButton.Name = "TurnZButton";
            this.TurnZButton.Size = new System.Drawing.Size(96, 36);
            this.TurnZButton.TabIndex = 3;
            this.TurnZButton.Text = "Повернуть по Z";
            this.TurnZButton.UseVisualStyleBackColor = true;
            this.TurnZButton.Click += new System.EventHandler(this.TurnZButton_Click);
            // 
            // TurnYButton
            // 
            this.TurnYButton.Location = new System.Drawing.Point(537, 347);
            this.TurnYButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TurnYButton.Name = "TurnYButton";
            this.TurnYButton.Size = new System.Drawing.Size(96, 36);
            this.TurnYButton.TabIndex = 4;
            this.TurnYButton.Text = "Повернуть по Y";
            this.TurnYButton.UseVisualStyleBackColor = true;
            this.TurnYButton.Click += new System.EventHandler(this.TurnYButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(537, 134);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(96, 26);
            this.MoveButton.TabIndex = 6;
            this.MoveButton.Text = "Переместить";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // numericUpDownMoveX
            // 
            this.numericUpDownMoveX.Location = new System.Drawing.Point(537, 68);
            this.numericUpDownMoveX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownMoveX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMoveX.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDownMoveX.Name = "numericUpDownMoveX";
            this.numericUpDownMoveX.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownMoveX.TabIndex = 7;
            // 
            // numericUpDownMoveY
            // 
            this.numericUpDownMoveY.Location = new System.Drawing.Point(537, 91);
            this.numericUpDownMoveY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownMoveY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMoveY.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDownMoveY.Name = "numericUpDownMoveY";
            this.numericUpDownMoveY.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownMoveY.TabIndex = 8;
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.Location = new System.Drawing.Point(537, 225);
            this.numericUpDownScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownScale.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownScale.TabIndex = 9;
            this.numericUpDownScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonScaling
            // 
            this.buttonScaling.Location = new System.Drawing.Point(537, 248);
            this.buttonScaling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonScaling.Name = "buttonScaling";
            this.buttonScaling.Size = new System.Drawing.Size(96, 36);
            this.buttonScaling.TabIndex = 10;
            this.buttonScaling.Text = "Изменить масштаб";
            this.buttonScaling.UseVisualStyleBackColor = true;
            this.buttonScaling.Click += new System.EventHandler(this.buttonScaling_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(652, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 120);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 535);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonScaling);
            this.Controls.Add(this.numericUpDownScale);
            this.Controls.Add(this.numericUpDownMoveY);
            this.Controls.Add(this.numericUpDownMoveX);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.TurnYButton);
            this.Controls.Add(this.TurnZButton);
            this.Controls.Add(this.TurnXButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoveX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoveY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TurnXButton;
        private System.Windows.Forms.Button TurnZButton;
        private System.Windows.Forms.Button TurnYButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.NumericUpDown numericUpDownMoveX;
        private System.Windows.Forms.NumericUpDown numericUpDownMoveY;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.Button buttonScaling;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

