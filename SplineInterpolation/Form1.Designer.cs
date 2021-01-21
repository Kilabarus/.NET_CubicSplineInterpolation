
namespace SplineInterpolation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnABSecondDerivatives = new System.Windows.Forms.Button();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.btnLetsGo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRightBoundCondition = new System.Windows.Forms.TextBox();
            this.tbLeftBoundCondition = new System.Windows.Forms.TextBox();
            this.lbRightBoundCondition = new System.Windows.Forms.Label();
            this.lbLeftBoundCondition = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRightBorder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLeftBorder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chFunctionAndInterpolation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.k = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chError = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFunctionAndInterpolation)).BeginInit();
            this.k.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnABSecondDerivatives);
            this.groupBox1.Controls.Add(this.nudN);
            this.groupBox1.Controls.Add(this.btnLetsGo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbRightBoundCondition);
            this.groupBox1.Controls.Add(this.tbLeftBoundCondition);
            this.groupBox1.Controls.Add(this.lbRightBoundCondition);
            this.groupBox1.Controls.Add(this.lbLeftBoundCondition);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbRightBorder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLeftBorder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFunction);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(402, 699);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные параметры";
            // 
            // btnABSecondDerivatives
            // 
            this.btnABSecondDerivatives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnABSecondDerivatives.Location = new System.Drawing.Point(214, 241);
            this.btnABSecondDerivatives.Name = "btnABSecondDerivatives";
            this.btnABSecondDerivatives.Size = new System.Drawing.Size(125, 60);
            this.btnABSecondDerivatives.TabIndex = 20;
            this.btnABSecondDerivatives.Text = "Задать A, B = f\'\'(a), f\'\'(b)";
            this.btnABSecondDerivatives.UseVisualStyleBackColor = true;
            this.btnABSecondDerivatives.Click += new System.EventHandler(this.btnABSecondDerivatives_Click);
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(58, 349);
            this.nudN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(76, 30);
            this.nudN.TabIndex = 17;
            this.nudN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnLetsGo
            // 
            this.btnLetsGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLetsGo.Location = new System.Drawing.Point(14, 403);
            this.btnLetsGo.Name = "btnLetsGo";
            this.btnLetsGo.Size = new System.Drawing.Size(171, 68);
            this.btnLetsGo.TabIndex = 16;
            this.btnLetsGo.Text = "Поехали!";
            this.btnLetsGo.UseVisualStyleBackColor = true;
            this.btnLetsGo.Click += new System.EventHandler(this.btnLetsGo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "N =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Число подотрезков разбиения";
            // 
            // tbRightBoundCondition
            // 
            this.tbRightBoundCondition.Location = new System.Drawing.Point(116, 274);
            this.tbRightBoundCondition.Name = "tbRightBoundCondition";
            this.tbRightBoundCondition.Size = new System.Drawing.Size(82, 30);
            this.tbRightBoundCondition.TabIndex = 12;
            // 
            // tbLeftBoundCondition
            // 
            this.tbLeftBoundCondition.Location = new System.Drawing.Point(116, 238);
            this.tbLeftBoundCondition.Name = "tbLeftBoundCondition";
            this.tbLeftBoundCondition.Size = new System.Drawing.Size(82, 30);
            this.tbLeftBoundCondition.TabIndex = 11;
            // 
            // lbRightBoundCondition
            // 
            this.lbRightBoundCondition.AutoSize = true;
            this.lbRightBoundCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRightBoundCondition.Location = new System.Drawing.Point(8, 273);
            this.lbRightBoundCondition.Name = "lbRightBoundCondition";
            this.lbRightBoundCondition.Size = new System.Drawing.Size(87, 29);
            this.lbRightBoundCondition.TabIndex = 10;
            this.lbRightBoundCondition.Text = "S\'\'(b) =";
            // 
            // lbLeftBoundCondition
            // 
            this.lbLeftBoundCondition.AutoSize = true;
            this.lbLeftBoundCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLeftBoundCondition.Location = new System.Drawing.Point(8, 239);
            this.lbLeftBoundCondition.Name = "lbLeftBoundCondition";
            this.lbLeftBoundCondition.Size = new System.Drawing.Size(86, 29);
            this.lbLeftBoundCondition.TabIndex = 9;
            this.lbLeftBoundCondition.Text = "S\'\'(a) =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Краевые условия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(122, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "]";
            // 
            // tbRightBorder
            // 
            this.tbRightBorder.Location = new System.Drawing.Point(84, 154);
            this.tbRightBorder.Name = "tbRightBorder";
            this.tbRightBorder.Size = new System.Drawing.Size(38, 30);
            this.tbRightBorder.TabIndex = 6;
            this.tbRightBorder.TextChanged += new System.EventHandler(this.tbRightBorder_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = ",";
            // 
            // tbLeftBorder
            // 
            this.tbLeftBorder.Location = new System.Drawing.Point(26, 154);
            this.tbLeftBorder.Name = "tbLeftBorder";
            this.tbLeftBorder.Size = new System.Drawing.Size(38, 30);
            this.tbLeftBorder.TabIndex = 4;
            this.tbLeftBorder.TextChanged += new System.EventHandler(this.tbLeftBorder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "[";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отрезок интерполирования";
            // 
            // cbFunction
            // 
            this.cbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Items.AddRange(new object[] {
            "x^3",
            "e^x",
            "Sin(x)",
            "Cos(x)",
            "Polynomial(x)"});
            this.cbFunction.Location = new System.Drawing.Point(12, 71);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(151, 33);
            this.cbFunction.TabIndex = 1;
            this.cbFunction.SelectedIndexChanged += new System.EventHandler(this.cbFunction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Интерполируемая функция";
            // 
            // chFunctionAndInterpolation
            // 
            chartArea1.Name = "ChartArea1";
            this.chFunctionAndInterpolation.ChartAreas.Add(chartArea1);
            this.chFunctionAndInterpolation.Location = new System.Drawing.Point(-18, 28);
            this.chFunctionAndInterpolation.Name = "chFunctionAndInterpolation";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Функция";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "Интерполяция";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Black;
            series3.MarkerSize = 10;
            series3.Name = "Узлы интерполяции";
            this.chFunctionAndInterpolation.Series.Add(series1);
            this.chFunctionAndInterpolation.Series.Add(series2);
            this.chFunctionAndInterpolation.Series.Add(series3);
            this.chFunctionAndInterpolation.Size = new System.Drawing.Size(691, 691);
            this.chFunctionAndInterpolation.TabIndex = 2;
            // 
            // k
            // 
            this.k.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k.Controls.Add(this.chFunctionAndInterpolation);
            this.k.Location = new System.Drawing.Point(422, 14);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(678, 699);
            this.k.TabIndex = 3;
            this.k.TabStop = false;
            this.k.Text = "График функции и её интерполяции";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.chError);
            this.groupBox2.Location = new System.Drawing.Point(1106, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 699);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "График погрешности";
            // 
            // chError
            // 
            chartArea2.Name = "ChartArea1";
            this.chError.ChartAreas.Add(chartArea2);
            this.chError.Location = new System.Drawing.Point(-18, 28);
            this.chError.Name = "chError";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Fuchsia;
            series4.Name = "Погрешность";
            this.chError.Series.Add(series4);
            this.chError.Size = new System.Drawing.Size(691, 691);
            this.chError.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 727);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.k);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFunctionAndInterpolation)).EndInit();
            this.k.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRightBoundCondition;
        private System.Windows.Forms.TextBox tbLeftBoundCondition;
        private System.Windows.Forms.Label lbRightBoundCondition;
        private System.Windows.Forms.Label lbLeftBoundCondition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRightBorder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLeftBorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFunctionAndInterpolation;
        private System.Windows.Forms.Button btnLetsGo;
        private System.Windows.Forms.GroupBox k;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chError;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Button btnABSecondDerivatives;
    }
}

