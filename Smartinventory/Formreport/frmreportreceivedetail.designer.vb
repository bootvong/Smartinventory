﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportreceivedetail
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportreceivedetail))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProduct = New DevComponents.DotNetBar.ButtonX()
        Me.txtproduct = New System.Windows.Forms.TextBox()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.btncry = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbsupcategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbcategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CrystalReportViewer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1132, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnProduct)
        Me.Panel1.Controls.Add(Me.txtproduct)
        Me.Panel1.Controls.Add(Me.date2)
        Me.Panel1.Controls.Add(Me.date1)
        Me.Panel1.Controls.Add(Me.btncry)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbsupcategory)
        Me.Panel1.Controls.Add(Me.cbcategory)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1126, 79)
        Me.Panel1.TabIndex = 0
        '
        'btnProduct
        '
        Me.btnProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnProduct.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnProduct.Location = New System.Drawing.Point(792, 36)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(54, 35)
        Me.btnProduct.TabIndex = 264
        Me.btnProduct.Text = "..."
        '
        'txtproduct
        '
        Me.txtproduct.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduct.Location = New System.Drawing.Point(552, 36)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Size = New System.Drawing.Size(234, 35)
        Me.txtproduct.TabIndex = 262
        '
        'date2
        '
        Me.date2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date2.Location = New System.Drawing.Point(57, 38)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(148, 34)
        Me.date2.TabIndex = 254
        '
        'date1
        '
        Me.date1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date1.Location = New System.Drawing.Point(57, 3)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(148, 34)
        Me.date1.TabIndex = 253
        '
        'btncry
        '
        Me.btncry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncry.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncry.ForeColor = System.Drawing.Color.Blue
        Me.btncry.Image = Global.Smartinventory.My.Resources.Resources.Report
        Me.btncry.Location = New System.Drawing.Point(852, 5)
        Me.btncry.Name = "btncry"
        Me.btncry.Size = New System.Drawing.Size(106, 67)
        Me.btncry.TabIndex = 207
        Me.btncry.Text = "ລາຍງານ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(10, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 24)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "ຫາ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 24)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "ວັນທີ:"
        '
        'cbsupcategory
        '
        Me.cbsupcategory.DisplayMember = "Text"
        Me.cbsupcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsupcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsupcategory.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsupcategory.ForeColor = System.Drawing.Color.Blue
        Me.cbsupcategory.FormattingEnabled = True
        Me.cbsupcategory.ItemHeight = 28
        Me.cbsupcategory.Location = New System.Drawing.Point(291, 39)
        Me.cbsupcategory.Name = "cbsupcategory"
        Me.cbsupcategory.Size = New System.Drawing.Size(187, 34)
        Me.cbsupcategory.TabIndex = 259
        '
        'cbcategory
        '
        Me.cbcategory.DisplayMember = "Text"
        Me.cbcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcategory.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcategory.ForeColor = System.Drawing.Color.Blue
        Me.cbcategory.FormattingEnabled = True
        Me.cbcategory.ItemHeight = 28
        Me.cbcategory.Location = New System.Drawing.Point(291, 4)
        Me.cbcategory.Name = "cbcategory"
        Me.cbcategory.Size = New System.Drawing.Size(187, 34)
        Me.cbcategory.TabIndex = 257
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(206, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 24)
        Me.Label14.TabIndex = 260
        Me.Label14.Text = "ປະເພດຍ່ອຍ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(204, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "ປະເພດຫລັກ:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(493, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 24)
        Me.Label8.TabIndex = 263
        Me.Label8.Text = "ຊື່ສີນຄ້າ:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 88)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1126, 638)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmreportreceivedetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1132, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmreportreceivedetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ລາຍງານລາຍລະອຽດການຮັບສີນຄ້າ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btncry As DevComponents.DotNetBar.ButtonX
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbsupcategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbcategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtproduct As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnProduct As DevComponents.DotNetBar.ButtonX
End Class
