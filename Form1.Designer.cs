
namespace Home_Field_Football_Tickets
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.cheapRadio = new System.Windows.Forms.RadioButton();
            this.customRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sectionBox = new System.Windows.Forms.ComboBox();
            this.rowBox = new System.Windows.Forms.ComboBox();
            this.seatList = new System.Windows.Forms.CheckedListBox();
            this.customGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ticketText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costDisplay = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.seatPic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sectionDisplay = new System.Windows.Forms.Label();
            this.rowDisplay = new System.Windows.Forms.Label();
            this.seatDisplay = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.customGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you for choosing Home Field Football Tickets\r\nPlease make your selections\r\n" +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentRadio
            // 
            this.studentRadio.AutoSize = true;
            this.studentRadio.Location = new System.Drawing.Point(32, 24);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(95, 17);
            this.studentRadio.TabIndex = 1;
            this.studentRadio.Text = "Student Ticket";
            this.studentRadio.UseVisualStyleBackColor = true;
            // 
            // cheapRadio
            // 
            this.cheapRadio.AutoSize = true;
            this.cheapRadio.Location = new System.Drawing.Point(32, 61);
            this.cheapRadio.Name = "cheapRadio";
            this.cheapRadio.Size = new System.Drawing.Size(100, 17);
            this.cheapRadio.TabIndex = 2;
            this.cheapRadio.Text = "Cheapest Seats";
            this.cheapRadio.UseVisualStyleBackColor = true;
            // 
            // customRadio
            // 
            this.customRadio.AutoSize = true;
            this.customRadio.Location = new System.Drawing.Point(32, 99);
            this.customRadio.Name = "customRadio";
            this.customRadio.Size = new System.Drawing.Size(96, 17);
            this.customRadio.TabIndex = 3;
            this.customRadio.Text = "Custom Choice";
            this.customRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customRadio);
            this.groupBox1.Controls.Add(this.cheapRadio);
            this.groupBox1.Controls.Add(this.studentRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please make a selection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sectionBox
            // 
            this.sectionBox.FormattingEnabled = true;
            this.sectionBox.Items.AddRange(new object[] {
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241"});
            this.sectionBox.Location = new System.Drawing.Point(26, 22);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(121, 21);
            this.sectionBox.TabIndex = 5;
            this.sectionBox.Text = "Choose a Section";
            // 
            // rowBox
            // 
            this.rowBox.FormattingEnabled = true;
            this.rowBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.rowBox.Location = new System.Drawing.Point(26, 63);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(121, 21);
            this.rowBox.TabIndex = 6;
            this.rowBox.Text = "Choose a Row";
            // 
            // seatList
            // 
            this.seatList.FormattingEnabled = true;
            this.seatList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.seatList.Location = new System.Drawing.Point(179, 38);
            this.seatList.Name = "seatList";
            this.seatList.Size = new System.Drawing.Size(58, 94);
            this.seatList.TabIndex = 7;
            // 
            // customGroup
            // 
            this.customGroup.Controls.Add(this.label2);
            this.customGroup.Controls.Add(this.seatList);
            this.customGroup.Controls.Add(this.rowBox);
            this.customGroup.Controls.Add(this.sectionBox);
            this.customGroup.Location = new System.Drawing.Point(190, 86);
            this.customGroup.Name = "customGroup";
            this.customGroup.Size = new System.Drawing.Size(272, 154);
            this.customGroup.TabIndex = 8;
            this.customGroup.TabStop = false;
            this.customGroup.Text = "Custom Choice Seats";
            this.customGroup.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chose your seat(s)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ticketText
            // 
            this.ticketText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketText.Location = new System.Drawing.Point(294, 328);
            this.ticketText.Name = "ticketText";
            this.ticketText.Size = new System.Drawing.Size(43, 27);
            this.ticketText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "How many tickets do you need?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Cost: ";
            // 
            // costDisplay
            // 
            this.costDisplay.AutoSize = true;
            this.costDisplay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costDisplay.Location = new System.Drawing.Point(128, 361);
            this.costDisplay.Name = "costDisplay";
            this.costDisplay.Size = new System.Drawing.Size(68, 19);
            this.costDisplay.TabIndex = 13;
            this.costDisplay.Text = "$000.00";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(16, 416);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 14;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(155, 416);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 15;
            this.payButton.Text = "Pay Now";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 264);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // seatPic
            // 
            this.seatPic.Image = ((System.Drawing.Image)(resources.GetObject("seatPic.Image")));
            this.seatPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("seatPic.InitialImage")));
            this.seatPic.Location = new System.Drawing.Point(567, 86);
            this.seatPic.Name = "seatPic";
            this.seatPic.Size = new System.Drawing.Size(529, 500);
            this.seatPic.TabIndex = 17;
            this.seatPic.TabStop = false;
            this.seatPic.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Your Section:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Your Row:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Your Seats:";
            // 
            // sectionDisplay
            // 
            this.sectionDisplay.AutoSize = true;
            this.sectionDisplay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionDisplay.Location = new System.Drawing.Point(140, 470);
            this.sectionDisplay.Name = "sectionDisplay";
            this.sectionDisplay.Size = new System.Drawing.Size(36, 19);
            this.sectionDisplay.TabIndex = 21;
            this.sectionDisplay.Text = "000";
            // 
            // rowDisplay
            // 
            this.rowDisplay.AutoSize = true;
            this.rowDisplay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowDisplay.Location = new System.Drawing.Point(140, 498);
            this.rowDisplay.Name = "rowDisplay";
            this.rowDisplay.Size = new System.Drawing.Size(18, 19);
            this.rowDisplay.TabIndex = 22;
            this.rowDisplay.Text = "0";
            // 
            // seatDisplay
            // 
            this.seatDisplay.AutoSize = true;
            this.seatDisplay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatDisplay.Location = new System.Drawing.Point(140, 524);
            this.seatDisplay.Name = "seatDisplay";
            this.seatDisplay.Size = new System.Drawing.Size(27, 19);
            this.seatDisplay.TabIndex = 23;
            this.seatDisplay.Text = "00";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(20, 559);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 24;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.seatDisplay);
            this.Controls.Add(this.rowDisplay);
            this.Controls.Add(this.sectionDisplay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.seatPic);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.costDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticketText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Home Field Football Tickets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.customGroup.ResumeLayout(false);
            this.customGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.RadioButton cheapRadio;
        private System.Windows.Forms.RadioButton customRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sectionBox;
        private System.Windows.Forms.ComboBox rowBox;
        private System.Windows.Forms.CheckedListBox seatList;
        private System.Windows.Forms.GroupBox customGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ticketText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label costDisplay;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox seatPic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label sectionDisplay;
        private System.Windows.Forms.Label rowDisplay;
        private System.Windows.Forms.Label seatDisplay;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

