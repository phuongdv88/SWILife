﻿Namespace DevExpress.MailClient.Win.Forms
	Partial Public Class ssMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ssMain))
            CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' marqueeProgressBarControl1
            ' 
            resources.ApplyResources(Me.marqueeProgressBarControl1, "marqueeProgressBarControl1")
            Me.marqueeProgressBarControl1.Properties.AccessibleDescription = resources.GetString("marqueeProgressBarControl1.Properties.AccessibleDescription")
            Me.marqueeProgressBarControl1.Properties.AccessibleName = resources.GetString("marqueeProgressBarControl1.Properties.AccessibleName")
            Me.marqueeProgressBarControl1.Properties.Appearance.BorderColor = (CType(resources.GetObject("marqueeProgressBarControl1.Properties.Appearance.BorderColor"), System.Drawing.Color))
            Me.marqueeProgressBarControl1.Properties.Appearance.FontSizeDelta = (CType(resources.GetObject("marqueeProgressBarControl1.Properties.Appearance.FontSizeDelta"), Integer))
            Me.marqueeProgressBarControl1.Properties.Appearance.FontStyleDelta = (CType(resources.GetObject("marqueeProgressBarControl1.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.marqueeProgressBarControl1.Properties.Appearance.GradientMode = (CType(resources.GetObject("marqueeProgressBarControl1.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.marqueeProgressBarControl1.Properties.Appearance.Image = (CType(resources.GetObject("marqueeProgressBarControl1.Properties.Appearance.Image"), System.Drawing.Image))
            Me.marqueeProgressBarControl1.Properties.AutoHeight = (CType(resources.GetObject("marqueeProgressBarControl1.Properties.AutoHeight"), Boolean))
            Me.marqueeProgressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.marqueeProgressBarControl1.Properties.LookAndFeel.SkinName = "Office 2013"
            Me.marqueeProgressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
            Me.marqueeProgressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
            Me.marqueeProgressBarControl1.Properties.ProgressPadding = New System.Windows.Forms.Padding(0)
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            ' 
            ' labelControl2
            ' 
            resources.ApplyResources(Me.labelControl2, "labelControl2")
            ' 
            ' pictureEdit1
            ' 
            resources.ApplyResources(Me.pictureEdit1, "pictureEdit1")
            Me.pictureEdit1.Properties.AccessibleDescription = resources.GetString("pictureEdit1.Properties.AccessibleDescription")
            Me.pictureEdit1.Properties.AccessibleName = resources.GetString("pictureEdit1.Properties.AccessibleName")
            Me.pictureEdit1.Properties.Appearance.BackColor = (CType(resources.GetObject("pictureEdit1.Properties.Appearance.BackColor"), System.Drawing.Color))
            Me.pictureEdit1.Properties.Appearance.FontSizeDelta = (CType(resources.GetObject("pictureEdit1.Properties.Appearance.FontSizeDelta"), Integer))
            Me.pictureEdit1.Properties.Appearance.FontStyleDelta = (CType(resources.GetObject("pictureEdit1.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.pictureEdit1.Properties.Appearance.GradientMode = (CType(resources.GetObject("pictureEdit1.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.pictureEdit1.Properties.Appearance.Image = (CType(resources.GetObject("pictureEdit1.Properties.Appearance.Image"), System.Drawing.Image))
            Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
            ' 
            ' panelControl
            ' 
            resources.ApplyResources(Me.panelControl, "panelControl")
            Me.panelControl.Appearance.BackColor = (CType(resources.GetObject("panelControl.Appearance.BackColor"), System.Drawing.Color))
            Me.panelControl.Appearance.FontSizeDelta = (CType(resources.GetObject("panelControl.Appearance.FontSizeDelta"), Integer))
            Me.panelControl.Appearance.FontStyleDelta = (CType(resources.GetObject("panelControl.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.panelControl.Appearance.GradientMode = (CType(resources.GetObject("panelControl.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.panelControl.Appearance.Image = (CType(resources.GetObject("panelControl.Appearance.Image"), System.Drawing.Image))
            Me.panelControl.Appearance.Options.UseBackColor = True
            ' 
            ' panelControl1
            ' 
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Appearance.BackColor = (CType(resources.GetObject("panelControl1.Appearance.BackColor"), System.Drawing.Color))
            Me.panelControl1.Appearance.FontSizeDelta = (CType(resources.GetObject("panelControl1.Appearance.FontSizeDelta"), Integer))
            Me.panelControl1.Appearance.FontStyleDelta = (CType(resources.GetObject("panelControl1.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.panelControl1.Appearance.GradientMode = (CType(resources.GetObject("panelControl1.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.panelControl1.Appearance.Image = (CType(resources.GetObject("panelControl1.Appearance.Image"), System.Drawing.Image))
            Me.panelControl1.Appearance.Options.UseBackColor = True
            ' 
            ' labelDemoText
            ' 
            resources.ApplyResources(Me.labelDemoText, "labelDemoText")
            Me.labelDemoText.AppearanceDisabled.Image = (CType(resources.GetObject("labelDemoText.Appearance.DisabledImage"), System.Drawing.Image))
            Me.labelDemoText.Appearance.Font = (CType(resources.GetObject("labelDemoText.Appearance.Font"), System.Drawing.Font))
            Me.labelDemoText.Appearance.FontSizeDelta = (CType(resources.GetObject("labelDemoText.Appearance.FontSizeDelta"), Integer))
            Me.labelDemoText.Appearance.FontStyleDelta = (CType(resources.GetObject("labelDemoText.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.labelDemoText.Appearance.ForeColor = (CType(resources.GetObject("labelDemoText.Appearance.ForeColor"), System.Drawing.Color))
            Me.labelDemoText.Appearance.GradientMode = (CType(resources.GetObject("labelDemoText.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.labelDemoText.AppearanceHovered.Image = (CType(resources.GetObject("labelDemoText.Appearance.HoverImage"), System.Drawing.Image))
            Me.labelDemoText.Appearance.Image = (CType(resources.GetObject("labelDemoText.Appearance.Image"), System.Drawing.Image))
            Me.labelDemoText.AppearancePressed.Image = (CType(resources.GetObject("labelDemoText.Appearance.PressedImage"), System.Drawing.Image))
            ' 
            ' pictureEdit2
            ' 
            resources.ApplyResources(Me.pictureEdit2, "pictureEdit2")
            Me.pictureEdit2.Properties.AccessibleDescription = resources.GetString("pictureEdit2.Properties.AccessibleDescription")
            Me.pictureEdit2.Properties.AccessibleName = resources.GetString("pictureEdit2.Properties.AccessibleName")
            Me.pictureEdit2.Properties.Appearance.BackColor = (CType(resources.GetObject("pictureEdit2.Properties.Appearance.BackColor"), System.Drawing.Color))
            Me.pictureEdit2.Properties.Appearance.FontSizeDelta = (CType(resources.GetObject("pictureEdit2.Properties.Appearance.FontSizeDelta"), Integer))
            Me.pictureEdit2.Properties.Appearance.FontStyleDelta = (CType(resources.GetObject("pictureEdit2.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.pictureEdit2.Properties.Appearance.GradientMode = (CType(resources.GetObject("pictureEdit2.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.pictureEdit2.Properties.Appearance.Image = (CType(resources.GetObject("pictureEdit2.Properties.Appearance.Image"), System.Drawing.Image))
            Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
            ' 
            ' labelProductText
            ' 
            resources.ApplyResources(Me.labelProductText, "labelProductText")
            Me.labelProductText.AppearanceDisabled.Image = (CType(resources.GetObject("labelProductText.Appearance.DisabledImage"), System.Drawing.Image))
            Me.labelProductText.Appearance.Font = (CType(resources.GetObject("labelProductText.Appearance.Font"), System.Drawing.Font))
            Me.labelProductText.Appearance.FontSizeDelta = (CType(resources.GetObject("labelProductText.Appearance.FontSizeDelta"), Integer))
            Me.labelProductText.Appearance.FontStyleDelta = (CType(resources.GetObject("labelProductText.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.labelProductText.Appearance.ForeColor = (CType(resources.GetObject("labelProductText.Appearance.ForeColor"), System.Drawing.Color))
            Me.labelProductText.Appearance.GradientMode = (CType(resources.GetObject("labelProductText.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.labelProductText.AppearanceHovered.Image = (CType(resources.GetObject("labelProductText.Appearance.HoverImage"), System.Drawing.Image))
            Me.labelProductText.Appearance.Image = (CType(resources.GetObject("labelProductText.Appearance.Image"), System.Drawing.Image))
            Me.labelProductText.AppearancePressed.Image = (CType(resources.GetObject("labelProductText.Appearance.PressedImage"), System.Drawing.Image))
            ' 
            ' ssMain
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "ssMain"
            CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
	End Class
End Namespace
