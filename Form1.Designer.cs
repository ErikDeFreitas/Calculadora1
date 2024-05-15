namespace Calculadora2;

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
        btnComma = new Button();
        btnZero = new Button();
        btnEqual = new Button();
        btnPlus = new Button();
        btnOne = new Button();
        btnTwo = new Button();
        btnThree = new Button();
        btnMinus = new Button();
        btnFour = new Button();
        btnFive = new Button();
        btnSix = new Button();
        btnMult = new Button();
        btnEight = new Button();
        btnSeven = new Button();
        btnNine = new Button();
        btnDiv = new Button();
        btnErase = new Button();
        txtResult = new TextBox();
        lblOp = new Label();
        SuspendLayout();
        // 
        // btnComma
        // 
        btnComma.Font = new Font("Segoe UI", 20F);
        btnComma.Location = new Point(12, 362);
        btnComma.Name = "btnComma";
        btnComma.Size = new Size(80, 80);
        btnComma.TabIndex = 0;
        btnComma.Text = ",";
        btnComma.UseVisualStyleBackColor = true;
        btnComma.Click += btnComma_Click;
        // 
        // btnZero
        // 
        btnZero.Font = new Font("Segoe UI", 20F);
        btnZero.Location = new Point(98, 362);
        btnZero.Name = "btnZero";
        btnZero.Size = new Size(80, 80);
        btnZero.TabIndex = 1;
        btnZero.Text = "0";
        btnZero.UseVisualStyleBackColor = true;
        btnZero.Click += btnZero_Click;
        // 
        // btnEqual
        // 
        btnEqual.Font = new Font("Segoe UI", 20F);
        btnEqual.Location = new Point(184, 362);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new Size(80, 80);
        btnEqual.TabIndex = 2;
        btnEqual.Text = "=";
        btnEqual.UseVisualStyleBackColor = true;
        btnEqual.Click += btnEqual_Click;
        // 
        // btnPlus
        // 
        btnPlus.BackColor = SystemColors.Control;
        btnPlus.Font = new Font("Segoe UI", 15F);
        btnPlus.Location = new Point(270, 362);
        btnPlus.Name = "btnPlus";
        btnPlus.Size = new Size(80, 80);
        btnPlus.TabIndex = 3;
        btnPlus.Text = "+";
        btnPlus.UseVisualStyleBackColor = true;
        btnPlus.Click += btnPlus_Click;
        // 
        // btnOne
        // 
        btnOne.Font = new Font("Segoe UI", 20F);
        btnOne.Location = new Point(12, 276);
        btnOne.Name = "btnOne";
        btnOne.Size = new Size(80, 80);
        btnOne.TabIndex = 4;
        btnOne.Text = "1";
        btnOne.UseVisualStyleBackColor = true;
        btnOne.Click += btnOne_Click;
        // 
        // btnTwo
        // 
        btnTwo.Font = new Font("Segoe UI", 20F);
        btnTwo.Location = new Point(98, 276);
        btnTwo.Name = "btnTwo";
        btnTwo.Size = new Size(80, 80);
        btnTwo.TabIndex = 5;
        btnTwo.Text = "2";
        btnTwo.UseVisualStyleBackColor = true;
        btnTwo.Click += btnTwo_Click;
        // 
        // btnThree
        // 
        btnThree.Font = new Font("Segoe UI", 20F);
        btnThree.Location = new Point(184, 276);
        btnThree.Name = "btnThree";
        btnThree.Size = new Size(80, 80);
        btnThree.TabIndex = 6;
        btnThree.Text = "3";
        btnThree.UseVisualStyleBackColor = true;
        btnThree.Click += btnThree_Click;
        // 
        // btnMinus
        // 
        btnMinus.Font = new Font("Segoe UI", 15F);
        btnMinus.Location = new Point(270, 276);
        btnMinus.Name = "btnMinus";
        btnMinus.Size = new Size(80, 80);
        btnMinus.TabIndex = 7;
        btnMinus.Text = "-";
        btnMinus.UseVisualStyleBackColor = true;
        btnMinus.Click += btnMinus_Click;
        // 
        // btnFour
        // 
        btnFour.Font = new Font("Segoe UI", 20F);
        btnFour.Location = new Point(12, 190);
        btnFour.Name = "btnFour";
        btnFour.Size = new Size(80, 80);
        btnFour.TabIndex = 8;
        btnFour.Text = "4";
        btnFour.UseVisualStyleBackColor = true;
        btnFour.Click += btnFour_Click;
        // 
        // btnFive
        // 
        btnFive.Font = new Font("Segoe UI", 20F);
        btnFive.Location = new Point(98, 190);
        btnFive.Name = "btnFive";
        btnFive.Size = new Size(80, 80);
        btnFive.TabIndex = 9;
        btnFive.Text = "5";
        btnFive.UseVisualStyleBackColor = true;
        btnFive.Click += btnFive_Click;
        // 
        // btnSix
        // 
        btnSix.Font = new Font("Segoe UI", 20F);
        btnSix.Location = new Point(184, 190);
        btnSix.Name = "btnSix";
        btnSix.Size = new Size(80, 80);
        btnSix.TabIndex = 10;
        btnSix.Text = "6";
        btnSix.UseVisualStyleBackColor = true;
        btnSix.Click += btnSix_Click;
        // 
        // btnMult
        // 
        btnMult.Font = new Font("Segoe UI", 15F);
        btnMult.Location = new Point(270, 190);
        btnMult.Name = "btnMult";
        btnMult.Size = new Size(80, 80);
        btnMult.TabIndex = 11;
        btnMult.Text = "*";
        btnMult.UseVisualStyleBackColor = true;
        btnMult.Click += btnMult_Click;
        // 
        // btnEight
        // 
        btnEight.Font = new Font("Segoe UI", 20F);
        btnEight.Location = new Point(98, 104);
        btnEight.Name = "btnEight";
        btnEight.Size = new Size(80, 80);
        btnEight.TabIndex = 12;
        btnEight.Text = "8";
        btnEight.UseVisualStyleBackColor = true;
        btnEight.Click += btnEight_Click;
        // 
        // btnSeven
        // 
        btnSeven.Font = new Font("Segoe UI", 20F);
        btnSeven.Location = new Point(12, 104);
        btnSeven.Name = "btnSeven";
        btnSeven.Size = new Size(80, 80);
        btnSeven.TabIndex = 13;
        btnSeven.Text = "7";
        btnSeven.UseVisualStyleBackColor = true;
        btnSeven.Click += btnSeven_Click;
        // 
        // btnNine
        // 
        btnNine.Font = new Font("Segoe UI", 20F);
        btnNine.Location = new Point(184, 104);
        btnNine.Name = "btnNine";
        btnNine.Size = new Size(80, 80);
        btnNine.TabIndex = 14;
        btnNine.Text = "9";
        btnNine.UseVisualStyleBackColor = true;
        btnNine.Click += btnNine_Click;
        // 
        // btnDiv
        // 
        btnDiv.Font = new Font("Segoe UI", 15F);
        btnDiv.Location = new Point(270, 104);
        btnDiv.Name = "btnDiv";
        btnDiv.Size = new Size(80, 80);
        btnDiv.TabIndex = 15;
        btnDiv.Text = "/";
        btnDiv.UseVisualStyleBackColor = true;
        btnDiv.Click += btnDiv_Click;
        // 
        // btnErase
        // 
        btnErase.Font = new Font("Segoe UI", 10F);
        btnErase.Location = new Point(270, 59);
        btnErase.Name = "btnErase";
        btnErase.Size = new Size(80, 37);
        btnErase.TabIndex = 16;
        btnErase.Text = "C";
        btnErase.UseVisualStyleBackColor = true;
        btnErase.Click += btnErase_Click;
        // 
        // txtResult
        // 
        txtResult.Font = new Font("Segoe UI", 15F);
        txtResult.Location = new Point(12, 12);
        txtResult.Name = "txtResult";
        txtResult.ReadOnly = true;
        txtResult.Size = new Size(338, 41);
        txtResult.TabIndex = 17;
        txtResult.TextAlign = HorizontalAlignment.Right;
        // 
        // lblOp
        // 
        lblOp.AutoSize = true;
        lblOp.Font = new Font("Segoe UI", 15F);
        lblOp.Location = new Point(21, 15);
        lblOp.Name = "lblOp";
        lblOp.Size = new Size(0, 35);
        lblOp.TabIndex = 19;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(364, 454);
        Controls.Add(lblOp);
        Controls.Add(txtResult);
        Controls.Add(btnErase);
        Controls.Add(btnDiv);
        Controls.Add(btnNine);
        Controls.Add(btnSeven);
        Controls.Add(btnEight);
        Controls.Add(btnMult);
        Controls.Add(btnSix);
        Controls.Add(btnFive);
        Controls.Add(btnFour);
        Controls.Add(btnMinus);
        Controls.Add(btnThree);
        Controls.Add(btnTwo);
        Controls.Add(btnOne);
        Controls.Add(btnPlus);
        Controls.Add(btnEqual);
        Controls.Add(btnZero);
        Controls.Add(btnComma);
        Name = "Form1";
        Text = "CalculaErik";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnComma;
    private Button btnZero;
    private Button btnEqual;
    private Button btnPlus;
    private Button btnOne;
    private Button btnTwo;
    private Button btnThree;
    private Button btnMinus;
    private Button btnFour;
    private Button btnFive;
    private Button btnSix;
    private Button btnMult;
    private Button btnEight;
    private Button btnSeven;
    private Button btnNine;
    private Button btnDiv;
    private Button btnErase;
    private TextBox txtResult;
    private Label lblOp;
}
