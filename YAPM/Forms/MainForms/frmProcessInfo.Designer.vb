﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessInfo
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim CConnection1 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim CConnection2 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessInfo))
        Dim CConnection3 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Services", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Search result", System.Windows.Forms.HorizontalAlignment.Left)
        Dim CConnection4 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Strings", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Search result", System.Windows.Forms.HorizontalAlignment.Left)
        Dim CConnection5 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Strings", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Search result", System.Windows.Forms.HorizontalAlignment.Left)
        Dim CConnection6 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim ListViewGroup7 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Modules", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup8 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Search result", System.Windows.Forms.HorizontalAlignment.Left)
        Dim CConnection7 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim ListViewGroup9 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Threads", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup10 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Search results", System.Windows.Forms.HorizontalAlignment.Left)
        Dim CConnection8 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Windows", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Search results", System.Windows.Forms.HorizontalAlignment.Left)
        Dim CConnection9 As CoreFunc.cConnection = New CoreFunc.cConnection
        Dim ListViewGroup13 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Handles", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup14 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Search result", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup15 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Strings", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup16 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Search result", System.Windows.Forms.HorizontalAlignment.Left)
        Me.tabProcess = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.cmdSet = New System.Windows.Forms.Button
        Me.cbPriority = New System.Windows.Forms.ComboBox
        Me.cmdAffinity = New System.Windows.Forms.Button
        Me.cmdPause = New System.Windows.Forms.Button
        Me.cmdResume = New System.Windows.Forms.Button
        Me.cmdKill = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.SplitContainerOnlineInfo = New System.Windows.Forms.SplitContainer
        Me.lblSecurityRisk = New System.Windows.Forms.Label
        Me.cmdGetOnlineInfos = New System.Windows.Forms.Button
        Me.rtbOnlineInfos = New System.Windows.Forms.RichTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRunTime = New System.Windows.Forms.TextBox
        Me.txtProcessStarted = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtParentProcess = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPriority = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCommandLine = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtProcessUser = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtProcessId = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.gpProcGeneralFile = New System.Windows.Forms.GroupBox
        Me.cmdInspectExe = New System.Windows.Forms.Button
        Me.cmdShowFileDetails = New System.Windows.Forms.Button
        Me.cmdShowFileProperties = New System.Windows.Forms.Button
        Me.cmdOpenDirectory = New System.Windows.Forms.Button
        Me.txtProcessPath = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtImageVersion = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.pctSmallIcon = New System.Windows.Forms.PictureBox
        Me.menuCopyPctSmall = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.pctBigIcon = New System.Windows.Forms.PictureBox
        Me.menuCopyPctbig = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblThreads = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.lblUserObjectsCount = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.lblGDIcount = New System.Windows.Forms.Label
        Me.lbl789 = New System.Windows.Forms.Label
        Me.lblHandles = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblOthersBD = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblOtherD = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblWBD = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblWD = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblRBD = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.lblRD = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lblProcOtherBytes = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblProcOther = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.lblProcWriteBytes = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblProcWrites = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.lblProcReadBytes = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.lblProcReads = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblQuotaNPP = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblQuotaPNPP = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lblQuotaPP = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.lblQuotaPPP = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.lblPageFaults = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.lblPeakPageFileUsage = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.lblPageFileUsage = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.lblPeakWorkingSet = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.lblWorkingSet = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblAverageCPUusage = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTotalTime = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblUserTime = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblKernelTime = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblPriority = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.splitPerformances = New System.Windows.Forms.SplitContainer
        Me.graphCPU = New YAPM.Graph2
        Me.splitPerformance2 = New System.Windows.Forms.SplitContainer
        Me.graphMemory = New YAPM.Graph2
        Me.graphIO = New YAPM.Graph2
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.tabProcessToken = New System.Windows.Forms.TabControl
        Me.tabProcessTokenPagePrivileges = New System.Windows.Forms.TabPage
        Me.lvPrivileges = New Providers.privilegeList
        Me.ColumnHeader50 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader51 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader52 = New System.Windows.Forms.ColumnHeader
        Me.menuPrivileges = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem44 = New System.Windows.Forms.ToolStripMenuItem
        Me.DisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.lvProcMem = New Providers.memoryList
        Me.ColumnHeader53 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader54 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader55 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader56 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.menuProcMem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem49 = New System.Windows.Forms.ToolStripMenuItem
        Me.JumpToPEBAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator
        Me.ChooseColumnsToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.SplitContainerInfoProcess = New System.Windows.Forms.SplitContainer
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdInfosToClipB = New System.Windows.Forms.Button
        Me.rtb = New System.Windows.Forms.RichTextBox
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.lvProcServices = New Providers.serviceList
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.menuProcServ = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ServiceDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem43 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator
        Me.PauseToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
        Me.StopToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
        Me.ShutdownShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
        Me.TypeOfStartToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem
        Me.DisabledToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem
        Me.DemandToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReanalyzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FilePropToolStripMenuItem34 = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenDirToolStripMenuItem35 = New System.Windows.Forms.ToolStripMenuItem
        Me.FileDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.GoogleSearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem37 = New System.Windows.Forms.ToolStripSeparator
        Me.ChooseColumnsToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.tabNetwork = New System.Windows.Forms.TabPage
        Me.lvProcNetwork = New Providers.networkList
        Me.ColumnHeader49 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader57 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader58 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader59 = New System.Windows.Forms.ColumnHeader
        Me.menuNetwork = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPageString = New System.Windows.Forms.TabPage
        Me.SplitContainerStrings = New System.Windows.Forms.SplitContainer
        Me.lvProcString = New YAPM.DoubleBufferedLV
        Me.ColumnHeader76 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader77 = New System.Windows.Forms.ColumnHeader
        Me.menuString = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuViewMemoryString = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdProcSearchR = New System.Windows.Forms.Button
        Me.cmdProcSearchL = New System.Windows.Forms.Button
        Me.pgbString = New System.Windows.Forms.ProgressBar
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtSearchProcString = New System.Windows.Forms.TextBox
        Me.cmdProcStringSave = New System.Windows.Forms.Button
        Me.optProcStringMemory = New System.Windows.Forms.RadioButton
        Me.optProcStringImage = New System.Windows.Forms.RadioButton
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.lvProcEnv = New Providers.envVariableList
        Me.ColumnHeader60 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader61 = New System.Windows.Forms.ColumnHeader
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.lvModules = New Providers.moduleList
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader43 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader44 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader45 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader46 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.menuModule = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowFileDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem36 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem39 = New System.Windows.Forms.ToolStripSeparator
        Me.GoogleSearchToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewMemoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator
        Me.ChooseColumnsToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage11 = New System.Windows.Forms.TabPage
        Me.lvThreads = New Providers.threadList
        Me.ColumnHeader32 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader34 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader35 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader36 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader37 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader38 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.menuThread = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem
        Me.LowestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem30 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem31 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem32 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem33 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.ChooseColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage12 = New System.Windows.Forms.TabPage
        Me.lvWindows = New Providers.windowList
        Me.ColumnHeader30 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader39 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader40 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader41 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader42 = New System.Windows.Forms.ColumnHeader
        Me.menuWindow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowUnnamedWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.BringToFrontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DoNotBringToFrontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetAsActiveWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetAsForegroundWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PositionSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.EnableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisableToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.ChooseColumnsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage13 = New System.Windows.Forms.TabPage
        Me.lvHandles = New Providers.handleList
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.menuHandles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.ShowUnnamedHandlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.ChooseColumnsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage14 = New System.Windows.Forms.TabPage
        Me.SplitContainerLog = New System.Windows.Forms.SplitContainer
        Me.cmdLogOptions = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdClearLog = New System.Windows.Forms.Button
        Me.chkLog = New System.Windows.Forms.CheckBox
        Me.lvLog = New YAPM.DoubleBufferedLV
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.TabPage15 = New System.Windows.Forms.TabPage
        Me.containerHistory = New System.Windows.Forms.SplitContainer
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstHistoryCat = New System.Windows.Forms.CheckedListBox
        Me.imgProcessTab = New System.Windows.Forms.ImageList(Me.components)
        Me.timerProcPerf = New System.Windows.Forms.Timer(Me.components)
        Me.imgProcess = New System.Windows.Forms.ImageList(Me.components)
        Me.imgMain = New System.Windows.Forms.ImageList(Me.components)
        Me.timerLog = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewDependenciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tabProcess.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SplitContainerOnlineInfo.Panel1.SuspendLayout()
        Me.SplitContainerOnlineInfo.Panel2.SuspendLayout()
        Me.SplitContainerOnlineInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpProcGeneralFile.SuspendLayout()
        CType(Me.pctSmallIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuCopyPctSmall.SuspendLayout()
        CType(Me.pctBigIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuCopyPctbig.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.splitPerformances.Panel1.SuspendLayout()
        Me.splitPerformances.Panel2.SuspendLayout()
        Me.splitPerformances.SuspendLayout()
        CType(Me.graphCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitPerformance2.Panel1.SuspendLayout()
        Me.splitPerformance2.Panel2.SuspendLayout()
        Me.splitPerformance2.SuspendLayout()
        CType(Me.graphMemory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graphIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.tabProcessToken.SuspendLayout()
        Me.tabProcessTokenPagePrivileges.SuspendLayout()
        Me.menuPrivileges.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.menuProcMem.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SplitContainerInfoProcess.Panel1.SuspendLayout()
        Me.SplitContainerInfoProcess.Panel2.SuspendLayout()
        Me.SplitContainerInfoProcess.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.menuProcServ.SuspendLayout()
        Me.tabNetwork.SuspendLayout()
        Me.menuNetwork.SuspendLayout()
        Me.TabPageString.SuspendLayout()
        Me.SplitContainerStrings.Panel1.SuspendLayout()
        Me.SplitContainerStrings.Panel2.SuspendLayout()
        Me.SplitContainerStrings.SuspendLayout()
        Me.menuString.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.menuModule.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.menuThread.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.menuWindow.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.menuHandles.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        Me.SplitContainerLog.Panel1.SuspendLayout()
        Me.SplitContainerLog.Panel2.SuspendLayout()
        Me.SplitContainerLog.SuspendLayout()
        Me.TabPage15.SuspendLayout()
        Me.containerHistory.Panel1.SuspendLayout()
        Me.containerHistory.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabProcess
        '
        Me.tabProcess.Controls.Add(Me.TabPage1)
        Me.tabProcess.Controls.Add(Me.TabPage2)
        Me.tabProcess.Controls.Add(Me.TabPage3)
        Me.tabProcess.Controls.Add(Me.TabPage4)
        Me.tabProcess.Controls.Add(Me.TabPage5)
        Me.tabProcess.Controls.Add(Me.TabPage6)
        Me.tabProcess.Controls.Add(Me.TabPage7)
        Me.tabProcess.Controls.Add(Me.tabNetwork)
        Me.tabProcess.Controls.Add(Me.TabPageString)
        Me.tabProcess.Controls.Add(Me.TabPage9)
        Me.tabProcess.Controls.Add(Me.TabPage10)
        Me.tabProcess.Controls.Add(Me.TabPage11)
        Me.tabProcess.Controls.Add(Me.TabPage12)
        Me.tabProcess.Controls.Add(Me.TabPage13)
        Me.tabProcess.Controls.Add(Me.TabPage14)
        Me.tabProcess.Controls.Add(Me.TabPage15)
        Me.tabProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabProcess.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProcess.ImageList = Me.imgProcessTab
        Me.tabProcess.Location = New System.Drawing.Point(0, 0)
        Me.tabProcess.Multiline = True
        Me.tabProcess.Name = "tabProcess"
        Me.tabProcess.SelectedIndex = 0
        Me.tabProcess.Size = New System.Drawing.Size(655, 323)
        Me.tabProcess.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.gpProcGeneralFile)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 42)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(647, 277)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmdSet)
        Me.GroupBox7.Controls.Add(Me.cbPriority)
        Me.GroupBox7.Controls.Add(Me.cmdAffinity)
        Me.GroupBox7.Controls.Add(Me.cmdPause)
        Me.GroupBox7.Controls.Add(Me.cmdResume)
        Me.GroupBox7.Controls.Add(Me.cmdKill)
        Me.GroupBox7.Location = New System.Drawing.Point(391, 179)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(242, 92)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Actions"
        '
        'cmdSet
        '
        Me.cmdSet.Location = New System.Drawing.Point(202, 50)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(31, 23)
        Me.cmdSet.TabIndex = 5
        Me.cmdSet.Text = "Set"
        Me.cmdSet.UseVisualStyleBackColor = True
        '
        'cbPriority
        '
        Me.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPriority.FormattingEnabled = True
        Me.cbPriority.Items.AddRange(New Object() {"Idle", "BelowNormal", "Normal", "AboveNormal", "High", "RealTime"})
        Me.cbPriority.Location = New System.Drawing.Point(91, 51)
        Me.cbPriority.Name = "cbPriority"
        Me.cbPriority.Size = New System.Drawing.Size(105, 21)
        Me.cbPriority.TabIndex = 4
        '
        'cmdAffinity
        '
        Me.cmdAffinity.Image = Global.YAPM.My.Resources.Resources.gear
        Me.cmdAffinity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAffinity.Location = New System.Drawing.Point(10, 50)
        Me.cmdAffinity.Name = "cmdAffinity"
        Me.cmdAffinity.Size = New System.Drawing.Size(75, 23)
        Me.cmdAffinity.TabIndex = 3
        Me.cmdAffinity.Text = "Affinity "
        Me.cmdAffinity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAffinity.UseVisualStyleBackColor = True
        '
        'cmdPause
        '
        Me.cmdPause.Image = Global.YAPM.My.Resources.Resources.control_pause
        Me.cmdPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPause.Location = New System.Drawing.Point(76, 21)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdPause.TabIndex = 2
        Me.cmdPause.Text = "Pause   "
        Me.cmdPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'cmdResume
        '
        Me.cmdResume.Image = Global.YAPM.My.Resources.Resources.control
        Me.cmdResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdResume.Location = New System.Drawing.Point(158, 21)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(75, 23)
        Me.cmdResume.TabIndex = 1
        Me.cmdResume.Text = "Resume "
        Me.cmdResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdResume.UseVisualStyleBackColor = True
        '
        'cmdKill
        '
        Me.cmdKill.Image = Global.YAPM.My.Resources.Resources.cross
        Me.cmdKill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKill.Location = New System.Drawing.Point(10, 21)
        Me.cmdKill.Name = "cmdKill"
        Me.cmdKill.Size = New System.Drawing.Size(60, 23)
        Me.cmdKill.TabIndex = 0
        Me.cmdKill.Text = "Kill   "
        Me.cmdKill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKill.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.SplitContainerOnlineInfo)
        Me.GroupBox6.Location = New System.Drawing.Point(391, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(242, 167)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Online informations"
        '
        'SplitContainerOnlineInfo
        '
        Me.SplitContainerOnlineInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerOnlineInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerOnlineInfo.IsSplitterFixed = True
        Me.SplitContainerOnlineInfo.Location = New System.Drawing.Point(3, 18)
        Me.SplitContainerOnlineInfo.Name = "SplitContainerOnlineInfo"
        Me.SplitContainerOnlineInfo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerOnlineInfo.Panel1
        '
        Me.SplitContainerOnlineInfo.Panel1.Controls.Add(Me.lblSecurityRisk)
        Me.SplitContainerOnlineInfo.Panel1.Controls.Add(Me.cmdGetOnlineInfos)
        '
        'SplitContainerOnlineInfo.Panel2
        '
        Me.SplitContainerOnlineInfo.Panel2.Controls.Add(Me.rtbOnlineInfos)
        Me.SplitContainerOnlineInfo.Size = New System.Drawing.Size(236, 146)
        Me.SplitContainerOnlineInfo.SplitterDistance = 25
        Me.SplitContainerOnlineInfo.TabIndex = 16
        '
        'lblSecurityRisk
        '
        Me.lblSecurityRisk.AutoSize = True
        Me.lblSecurityRisk.Location = New System.Drawing.Point(124, 6)
        Me.lblSecurityRisk.Name = "lblSecurityRisk"
        Me.lblSecurityRisk.Size = New System.Drawing.Size(74, 13)
        Me.lblSecurityRisk.TabIndex = 2
        Me.lblSecurityRisk.Text = "Not yet rated"
        '
        'cmdGetOnlineInfos
        '
        Me.cmdGetOnlineInfos.Location = New System.Drawing.Point(10, 1)
        Me.cmdGetOnlineInfos.Name = "cmdGetOnlineInfos"
        Me.cmdGetOnlineInfos.Size = New System.Drawing.Size(108, 23)
        Me.cmdGetOnlineInfos.TabIndex = 11
        Me.cmdGetOnlineInfos.Text = "Get online infos"
        Me.cmdGetOnlineInfos.UseVisualStyleBackColor = True
        '
        'rtbOnlineInfos
        '
        Me.rtbOnlineInfos.AutoWordSelection = True
        Me.rtbOnlineInfos.BackColor = System.Drawing.Color.White
        Me.rtbOnlineInfos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbOnlineInfos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbOnlineInfos.HideSelection = False
        Me.rtbOnlineInfos.Location = New System.Drawing.Point(0, 0)
        Me.rtbOnlineInfos.Name = "rtbOnlineInfos"
        Me.rtbOnlineInfos.ReadOnly = True
        Me.rtbOnlineInfos.Size = New System.Drawing.Size(236, 117)
        Me.rtbOnlineInfos.TabIndex = 12
        Me.rtbOnlineInfos.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRunTime)
        Me.GroupBox1.Controls.Add(Me.txtProcessStarted)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtParentProcess)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtPriority)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCommandLine)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtProcessUser)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtProcessId)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 142)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process"
        '
        'txtRunTime
        '
        Me.txtRunTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRunTime.Location = New System.Drawing.Point(292, 66)
        Me.txtRunTime.Name = "txtRunTime"
        Me.txtRunTime.ReadOnly = True
        Me.txtRunTime.Size = New System.Drawing.Size(79, 22)
        Me.txtRunTime.TabIndex = 31
        '
        'txtProcessStarted
        '
        Me.txtProcessStarted.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProcessStarted.Location = New System.Drawing.Point(89, 66)
        Me.txtProcessStarted.Name = "txtProcessStarted"
        Me.txtProcessStarted.ReadOnly = True
        Me.txtProcessStarted.Size = New System.Drawing.Size(197, 22)
        Me.txtProcessStarted.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Start/run time"
        '
        'txtParentProcess
        '
        Me.txtParentProcess.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtParentProcess.Location = New System.Drawing.Point(89, 43)
        Me.txtParentProcess.Name = "txtParentProcess"
        Me.txtParentProcess.ReadOnly = True
        Me.txtParentProcess.Size = New System.Drawing.Size(282, 22)
        Me.txtParentProcess.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Parent process"
        '
        'txtPriority
        '
        Me.txtPriority.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPriority.Location = New System.Drawing.Point(237, 20)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.ReadOnly = True
        Me.txtPriority.Size = New System.Drawing.Size(134, 22)
        Me.txtPriority.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Priority"
        '
        'txtCommandLine
        '
        Me.txtCommandLine.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCommandLine.Location = New System.Drawing.Point(89, 114)
        Me.txtCommandLine.Name = "txtCommandLine"
        Me.txtCommandLine.ReadOnly = True
        Me.txtCommandLine.Size = New System.Drawing.Size(282, 22)
        Me.txtCommandLine.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Command line"
        '
        'txtProcessUser
        '
        Me.txtProcessUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProcessUser.Location = New System.Drawing.Point(89, 90)
        Me.txtProcessUser.Name = "txtProcessUser"
        Me.txtProcessUser.ReadOnly = True
        Me.txtProcessUser.Size = New System.Drawing.Size(282, 22)
        Me.txtProcessUser.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "User"
        '
        'txtProcessId
        '
        Me.txtProcessId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProcessId.Location = New System.Drawing.Point(89, 19)
        Me.txtProcessId.Name = "txtProcessId"
        Me.txtProcessId.ReadOnly = True
        Me.txtProcessId.Size = New System.Drawing.Size(93, 22)
        Me.txtProcessId.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Pid"
        '
        'gpProcGeneralFile
        '
        Me.gpProcGeneralFile.Controls.Add(Me.cmdInspectExe)
        Me.gpProcGeneralFile.Controls.Add(Me.cmdShowFileDetails)
        Me.gpProcGeneralFile.Controls.Add(Me.cmdShowFileProperties)
        Me.gpProcGeneralFile.Controls.Add(Me.cmdOpenDirectory)
        Me.gpProcGeneralFile.Controls.Add(Me.txtProcessPath)
        Me.gpProcGeneralFile.Controls.Add(Me.Label13)
        Me.gpProcGeneralFile.Controls.Add(Me.txtImageVersion)
        Me.gpProcGeneralFile.Controls.Add(Me.Label12)
        Me.gpProcGeneralFile.Controls.Add(Me.lblCopyright)
        Me.gpProcGeneralFile.Controls.Add(Me.lblDescription)
        Me.gpProcGeneralFile.Controls.Add(Me.pctSmallIcon)
        Me.gpProcGeneralFile.Controls.Add(Me.pctBigIcon)
        Me.gpProcGeneralFile.Location = New System.Drawing.Point(6, 6)
        Me.gpProcGeneralFile.Name = "gpProcGeneralFile"
        Me.gpProcGeneralFile.Size = New System.Drawing.Size(376, 117)
        Me.gpProcGeneralFile.TabIndex = 15
        Me.gpProcGeneralFile.TabStop = False
        Me.gpProcGeneralFile.Text = "Image file"
        '
        'cmdInspectExe
        '
        Me.cmdInspectExe.Image = Global.YAPM.My.Resources.Resources.dllIcon
        Me.cmdInspectExe.Location = New System.Drawing.Point(266, 81)
        Me.cmdInspectExe.Name = "cmdInspectExe"
        Me.cmdInspectExe.Size = New System.Drawing.Size(26, 26)
        Me.cmdInspectExe.TabIndex = 18
        Me.cmdInspectExe.UseVisualStyleBackColor = True
        '
        'cmdShowFileDetails
        '
        Me.cmdShowFileDetails.Image = Global.YAPM.My.Resources.Resources.magnifier
        Me.cmdShowFileDetails.Location = New System.Drawing.Point(292, 81)
        Me.cmdShowFileDetails.Name = "cmdShowFileDetails"
        Me.cmdShowFileDetails.Size = New System.Drawing.Size(26, 26)
        Me.cmdShowFileDetails.TabIndex = 3
        Me.cmdShowFileDetails.UseVisualStyleBackColor = True
        '
        'cmdShowFileProperties
        '
        Me.cmdShowFileProperties.Image = Global.YAPM.My.Resources.Resources.document_text
        Me.cmdShowFileProperties.Location = New System.Drawing.Point(318, 81)
        Me.cmdShowFileProperties.Name = "cmdShowFileProperties"
        Me.cmdShowFileProperties.Size = New System.Drawing.Size(26, 26)
        Me.cmdShowFileProperties.TabIndex = 4
        Me.cmdShowFileProperties.UseVisualStyleBackColor = True
        '
        'cmdOpenDirectory
        '
        Me.cmdOpenDirectory.Image = Global.YAPM.My.Resources.Resources.folder_open_document
        Me.cmdOpenDirectory.Location = New System.Drawing.Point(344, 81)
        Me.cmdOpenDirectory.Name = "cmdOpenDirectory"
        Me.cmdOpenDirectory.Size = New System.Drawing.Size(26, 26)
        Me.cmdOpenDirectory.TabIndex = 5
        Me.cmdOpenDirectory.UseVisualStyleBackColor = True
        '
        'txtProcessPath
        '
        Me.txtProcessPath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProcessPath.Location = New System.Drawing.Point(85, 82)
        Me.txtProcessPath.Name = "txtProcessPath"
        Me.txtProcessPath.ReadOnly = True
        Me.txtProcessPath.Size = New System.Drawing.Size(175, 22)
        Me.txtProcessPath.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Image path"
        '
        'txtImageVersion
        '
        Me.txtImageVersion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtImageVersion.Location = New System.Drawing.Point(85, 59)
        Me.txtImageVersion.Name = "txtImageVersion"
        Me.txtImageVersion.ReadOnly = True
        Me.txtImageVersion.Size = New System.Drawing.Size(285, 22)
        Me.txtImageVersion.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Image version"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(82, 38)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(77, 13)
        Me.lblCopyright.TabIndex = 14
        Me.lblCopyright.Text = "File copyright"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(82, 19)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(86, 13)
        Me.lblDescription.TabIndex = 13
        Me.lblDescription.Text = "File description"
        '
        'pctSmallIcon
        '
        Me.pctSmallIcon.ContextMenuStrip = Me.menuCopyPctSmall
        Me.pctSmallIcon.Location = New System.Drawing.Point(44, 35)
        Me.pctSmallIcon.Name = "pctSmallIcon"
        Me.pctSmallIcon.Size = New System.Drawing.Size(16, 16)
        Me.pctSmallIcon.TabIndex = 12
        Me.pctSmallIcon.TabStop = False
        '
        'menuCopyPctSmall
        '
        Me.menuCopyPctSmall.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7})
        Me.menuCopyPctSmall.Name = "menuCopyPctbig"
        Me.menuCopyPctSmall.Size = New System.Drawing.Size(170, 26)
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Image = Global.YAPM.My.Resources.Resources.copy16
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem7.Text = "Copy to clipboard"
        '
        'pctBigIcon
        '
        Me.pctBigIcon.ContextMenuStrip = Me.menuCopyPctbig
        Me.pctBigIcon.Location = New System.Drawing.Point(6, 19)
        Me.pctBigIcon.Name = "pctBigIcon"
        Me.pctBigIcon.Size = New System.Drawing.Size(32, 32)
        Me.pctBigIcon.TabIndex = 11
        Me.pctBigIcon.TabStop = False
        '
        'menuCopyPctbig
        '
        Me.menuCopyPctbig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.menuCopyPctbig.Name = "menuCopyPctbig"
        Me.menuCopyPctbig.Size = New System.Drawing.Size(170, 26)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Image = Global.YAPM.My.Resources.Resources.copy16
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem6.Text = "Copy to clipboard"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 42)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(647, 277)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Statistics"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblThreads)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.lblUserObjectsCount)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.lblGDIcount)
        Me.GroupBox5.Controls.Add(Me.lbl789)
        Me.GroupBox5.Controls.Add(Me.lblHandles)
        Me.GroupBox5.Controls.Add(Me.Label53)
        Me.GroupBox5.Location = New System.Drawing.Point(416, 135)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(180, 122)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Other"
        '
        'lblThreads
        '
        Me.lblThreads.AutoSize = True
        Me.lblThreads.Location = New System.Drawing.Point(102, 72)
        Me.lblThreads.Name = "lblThreads"
        Me.lblThreads.Size = New System.Drawing.Size(19, 13)
        Me.lblThreads.TabIndex = 7
        Me.lblThreads.Text = "00"
        Me.lblThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(8, 72)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(47, 13)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "Threads"
        '
        'lblUserObjectsCount
        '
        Me.lblUserObjectsCount.AutoSize = True
        Me.lblUserObjectsCount.Location = New System.Drawing.Point(102, 54)
        Me.lblUserObjectsCount.Name = "lblUserObjectsCount"
        Me.lblUserObjectsCount.Size = New System.Drawing.Size(19, 13)
        Me.lblUserObjectsCount.TabIndex = 5
        Me.lblUserObjectsCount.Text = "00"
        Me.lblUserObjectsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(8, 54)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(70, 13)
        Me.Label37.TabIndex = 4
        Me.Label37.Text = "User objects"
        '
        'lblGDIcount
        '
        Me.lblGDIcount.AutoSize = True
        Me.lblGDIcount.Location = New System.Drawing.Point(102, 35)
        Me.lblGDIcount.Name = "lblGDIcount"
        Me.lblGDIcount.Size = New System.Drawing.Size(19, 13)
        Me.lblGDIcount.TabIndex = 3
        Me.lblGDIcount.Text = "00"
        Me.lblGDIcount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl789
        '
        Me.lbl789.AutoSize = True
        Me.lbl789.Location = New System.Drawing.Point(8, 35)
        Me.lbl789.Name = "lbl789"
        Me.lbl789.Size = New System.Drawing.Size(66, 13)
        Me.lbl789.TabIndex = 2
        Me.lbl789.Text = "GDI objects"
        '
        'lblHandles
        '
        Me.lblHandles.AutoSize = True
        Me.lblHandles.Location = New System.Drawing.Point(102, 16)
        Me.lblHandles.Name = "lblHandles"
        Me.lblHandles.Size = New System.Drawing.Size(19, 13)
        Me.lblHandles.TabIndex = 1
        Me.lblHandles.Text = "00"
        Me.lblHandles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(8, 16)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(49, 13)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Handles"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblOthersBD)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lblOtherD)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.lblWBD)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.lblWD)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lblRBD)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.lblRD)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.lblProcOtherBytes)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.lblProcOther)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.lblProcWriteBytes)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.lblProcWrites)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.lblProcReadBytes)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.lblProcReads)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Location = New System.Drawing.Point(234, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 249)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "I/O"
        '
        'lblOthersBD
        '
        Me.lblOthersBD.AutoSize = True
        Me.lblOthersBD.Location = New System.Drawing.Point(102, 217)
        Me.lblOthersBD.Name = "lblOthersBD"
        Me.lblOthersBD.Size = New System.Drawing.Size(19, 13)
        Me.lblOthersBD.TabIndex = 43
        Me.lblOthersBD.Text = "00"
        Me.lblOthersBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Other bytes delta"
        '
        'lblOtherD
        '
        Me.lblOtherD.AutoSize = True
        Me.lblOtherD.Location = New System.Drawing.Point(102, 199)
        Me.lblOtherD.Name = "lblOtherD"
        Me.lblOtherD.Size = New System.Drawing.Size(19, 13)
        Me.lblOtherD.TabIndex = 41
        Me.lblOtherD.Text = "00"
        Me.lblOtherD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Other delta"
        '
        'lblWBD
        '
        Me.lblWBD.AutoSize = True
        Me.lblWBD.Location = New System.Drawing.Point(102, 180)
        Me.lblWBD.Name = "lblWBD"
        Me.lblWBD.Size = New System.Drawing.Size(19, 13)
        Me.lblWBD.TabIndex = 39
        Me.lblWBD.Text = "00"
        Me.lblWBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Write bytes delta"
        '
        'lblWD
        '
        Me.lblWD.AutoSize = True
        Me.lblWD.Location = New System.Drawing.Point(102, 162)
        Me.lblWD.Name = "lblWD"
        Me.lblWD.Size = New System.Drawing.Size(19, 13)
        Me.lblWD.TabIndex = 37
        Me.lblWD.Text = "00"
        Me.lblWD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Writes delta"
        '
        'lblRBD
        '
        Me.lblRBD.AutoSize = True
        Me.lblRBD.Location = New System.Drawing.Point(102, 144)
        Me.lblRBD.Name = "lblRBD"
        Me.lblRBD.Size = New System.Drawing.Size(19, 13)
        Me.lblRBD.TabIndex = 35
        Me.lblRBD.Text = "00"
        Me.lblRBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 144)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(92, 13)
        Me.Label34.TabIndex = 34
        Me.Label34.Text = "Read bytes delta"
        '
        'lblRD
        '
        Me.lblRD.AutoSize = True
        Me.lblRD.Location = New System.Drawing.Point(102, 126)
        Me.lblRD.Name = "lblRD"
        Me.lblRD.Size = New System.Drawing.Size(19, 13)
        Me.lblRD.TabIndex = 33
        Me.lblRD.Text = "00"
        Me.lblRD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(6, 126)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(67, 13)
        Me.Label41.TabIndex = 32
        Me.Label41.Text = "Reads delta"
        '
        'lblProcOtherBytes
        '
        Me.lblProcOtherBytes.AutoSize = True
        Me.lblProcOtherBytes.Location = New System.Drawing.Point(102, 107)
        Me.lblProcOtherBytes.Name = "lblProcOtherBytes"
        Me.lblProcOtherBytes.Size = New System.Drawing.Size(19, 13)
        Me.lblProcOtherBytes.TabIndex = 31
        Me.lblProcOtherBytes.Text = "00"
        Me.lblProcOtherBytes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 107)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Other bytes"
        '
        'lblProcOther
        '
        Me.lblProcOther.AutoSize = True
        Me.lblProcOther.Location = New System.Drawing.Point(102, 89)
        Me.lblProcOther.Name = "lblProcOther"
        Me.lblProcOther.Size = New System.Drawing.Size(19, 13)
        Me.lblProcOther.TabIndex = 29
        Me.lblProcOther.Text = "00"
        Me.lblProcOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 89)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 13)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "Other"
        '
        'lblProcWriteBytes
        '
        Me.lblProcWriteBytes.AutoSize = True
        Me.lblProcWriteBytes.Location = New System.Drawing.Point(102, 70)
        Me.lblProcWriteBytes.Name = "lblProcWriteBytes"
        Me.lblProcWriteBytes.Size = New System.Drawing.Size(19, 13)
        Me.lblProcWriteBytes.TabIndex = 27
        Me.lblProcWriteBytes.Text = "00"
        Me.lblProcWriteBytes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 70)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(65, 13)
        Me.Label36.TabIndex = 26
        Me.Label36.Text = "Write bytes"
        '
        'lblProcWrites
        '
        Me.lblProcWrites.AutoSize = True
        Me.lblProcWrites.Location = New System.Drawing.Point(102, 52)
        Me.lblProcWrites.Name = "lblProcWrites"
        Me.lblProcWrites.Size = New System.Drawing.Size(19, 13)
        Me.lblProcWrites.TabIndex = 25
        Me.lblProcWrites.Text = "00"
        Me.lblProcWrites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 52)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 13)
        Me.Label38.TabIndex = 24
        Me.Label38.Text = "Writes"
        '
        'lblProcReadBytes
        '
        Me.lblProcReadBytes.AutoSize = True
        Me.lblProcReadBytes.Location = New System.Drawing.Point(102, 34)
        Me.lblProcReadBytes.Name = "lblProcReadBytes"
        Me.lblProcReadBytes.Size = New System.Drawing.Size(19, 13)
        Me.lblProcReadBytes.TabIndex = 23
        Me.lblProcReadBytes.Text = "00"
        Me.lblProcReadBytes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(6, 34)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(63, 13)
        Me.Label40.TabIndex = 22
        Me.Label40.Text = "Read bytes"
        '
        'lblProcReads
        '
        Me.lblProcReads.AutoSize = True
        Me.lblProcReads.Location = New System.Drawing.Point(102, 16)
        Me.lblProcReads.Name = "lblProcReads"
        Me.lblProcReads.Size = New System.Drawing.Size(19, 13)
        Me.lblProcReads.TabIndex = 21
        Me.lblProcReads.Text = "00"
        Me.lblProcReads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(6, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(38, 13)
        Me.Label42.TabIndex = 20
        Me.Label42.Text = "Reads"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblQuotaNPP)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.lblQuotaPNPP)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.lblQuotaPP)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.lblQuotaPPP)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.lblPageFaults)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.lblPeakPageFileUsage)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.lblPageFileUsage)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.lblPeakWorkingSet)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.lblWorkingSet)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 249)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Memory"
        '
        'lblQuotaNPP
        '
        Me.lblQuotaNPP.AutoSize = True
        Me.lblQuotaNPP.Location = New System.Drawing.Point(146, 145)
        Me.lblQuotaNPP.Name = "lblQuotaNPP"
        Me.lblQuotaNPP.Size = New System.Drawing.Size(19, 13)
        Me.lblQuotaNPP.TabIndex = 23
        Me.lblQuotaNPP.Text = "00"
        Me.lblQuotaNPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 145)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(117, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "QuotaNonPagedPool"
        '
        'lblQuotaPNPP
        '
        Me.lblQuotaPNPP.AutoSize = True
        Me.lblQuotaPNPP.Location = New System.Drawing.Point(146, 127)
        Me.lblQuotaPNPP.Name = "lblQuotaPNPP"
        Me.lblQuotaPNPP.Size = New System.Drawing.Size(19, 13)
        Me.lblQuotaPNPP.TabIndex = 21
        Me.lblQuotaPNPP.Text = "00"
        Me.lblQuotaPNPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(5, 127)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(141, 13)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "QuotaPeakNonPagedPool"
        '
        'lblQuotaPP
        '
        Me.lblQuotaPP.AutoSize = True
        Me.lblQuotaPP.Location = New System.Drawing.Point(146, 109)
        Me.lblQuotaPP.Name = "lblQuotaPP"
        Me.lblQuotaPP.Size = New System.Drawing.Size(19, 13)
        Me.lblQuotaPP.TabIndex = 19
        Me.lblQuotaPP.Text = "00"
        Me.lblQuotaPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(5, 109)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(95, 13)
        Me.Label29.TabIndex = 18
        Me.Label29.Text = "QuotaPagedPool"
        '
        'lblQuotaPPP
        '
        Me.lblQuotaPPP.AutoSize = True
        Me.lblQuotaPPP.Location = New System.Drawing.Point(146, 91)
        Me.lblQuotaPPP.Name = "lblQuotaPPP"
        Me.lblQuotaPPP.Size = New System.Drawing.Size(19, 13)
        Me.lblQuotaPPP.TabIndex = 17
        Me.lblQuotaPPP.Text = "00"
        Me.lblQuotaPPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(5, 91)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(119, 13)
        Me.Label32.TabIndex = 16
        Me.Label32.Text = "QuotaPeakPagedPool"
        '
        'lblPageFaults
        '
        Me.lblPageFaults.AutoSize = True
        Me.lblPageFaults.Location = New System.Drawing.Point(146, 163)
        Me.lblPageFaults.Name = "lblPageFaults"
        Me.lblPageFaults.Size = New System.Drawing.Size(19, 13)
        Me.lblPageFaults.TabIndex = 15
        Me.lblPageFaults.Text = "00"
        Me.lblPageFaults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(5, 163)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 13)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "Page faults"
        '
        'lblPeakPageFileUsage
        '
        Me.lblPeakPageFileUsage.AutoSize = True
        Me.lblPeakPageFileUsage.Location = New System.Drawing.Point(146, 72)
        Me.lblPeakPageFileUsage.Name = "lblPeakPageFileUsage"
        Me.lblPeakPageFileUsage.Size = New System.Drawing.Size(19, 13)
        Me.lblPeakPageFileUsage.TabIndex = 13
        Me.lblPeakPageFileUsage.Text = "00"
        Me.lblPeakPageFileUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(5, 72)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(113, 13)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "Peak page file usage"
        '
        'lblPageFileUsage
        '
        Me.lblPageFileUsage.AutoSize = True
        Me.lblPageFileUsage.Location = New System.Drawing.Point(146, 54)
        Me.lblPageFileUsage.Name = "lblPageFileUsage"
        Me.lblPageFileUsage.Size = New System.Drawing.Size(19, 13)
        Me.lblPageFileUsage.TabIndex = 11
        Me.lblPageFileUsage.Text = "00"
        Me.lblPageFileUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(5, 54)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(82, 13)
        Me.Label35.TabIndex = 10
        Me.Label35.Text = "Pagefile usage"
        '
        'lblPeakWorkingSet
        '
        Me.lblPeakWorkingSet.AutoSize = True
        Me.lblPeakWorkingSet.Location = New System.Drawing.Point(146, 36)
        Me.lblPeakWorkingSet.Name = "lblPeakWorkingSet"
        Me.lblPeakWorkingSet.Size = New System.Drawing.Size(19, 13)
        Me.lblPeakWorkingSet.TabIndex = 5
        Me.lblPeakWorkingSet.Text = "00"
        Me.lblPeakWorkingSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(5, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Peak working set"
        '
        'lblWorkingSet
        '
        Me.lblWorkingSet.AutoSize = True
        Me.lblWorkingSet.Location = New System.Drawing.Point(146, 18)
        Me.lblWorkingSet.Name = "lblWorkingSet"
        Me.lblWorkingSet.Size = New System.Drawing.Size(19, 13)
        Me.lblWorkingSet.TabIndex = 3
        Me.lblWorkingSet.Text = "00"
        Me.lblWorkingSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Working set"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAverageCPUusage)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblTotalTime)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.lblUserTime)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblKernelTime)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lblPriority)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 120)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CPU"
        '
        'lblAverageCPUusage
        '
        Me.lblAverageCPUusage.AutoSize = True
        Me.lblAverageCPUusage.Location = New System.Drawing.Point(100, 91)
        Me.lblAverageCPUusage.Name = "lblAverageCPUusage"
        Me.lblAverageCPUusage.Size = New System.Drawing.Size(19, 13)
        Me.lblAverageCPUusage.TabIndex = 9
        Me.lblAverageCPUusage.Text = "00"
        Me.lblAverageCPUusage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Average usage"
        '
        'lblTotalTime
        '
        Me.lblTotalTime.AutoSize = True
        Me.lblTotalTime.Location = New System.Drawing.Point(100, 73)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(70, 13)
        Me.lblTotalTime.TabIndex = 7
        Me.lblTotalTime.Text = "00:00:00.158"
        Me.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 73)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Total time"
        '
        'lblUserTime
        '
        Me.lblUserTime.AutoSize = True
        Me.lblUserTime.Location = New System.Drawing.Point(100, 54)
        Me.lblUserTime.Name = "lblUserTime"
        Me.lblUserTime.Size = New System.Drawing.Size(19, 13)
        Me.lblUserTime.TabIndex = 5
        Me.lblUserTime.Text = "00"
        Me.lblUserTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "User time"
        '
        'lblKernelTime
        '
        Me.lblKernelTime.AutoSize = True
        Me.lblKernelTime.Location = New System.Drawing.Point(100, 36)
        Me.lblKernelTime.Name = "lblKernelTime"
        Me.lblKernelTime.Size = New System.Drawing.Size(19, 13)
        Me.lblKernelTime.TabIndex = 3
        Me.lblKernelTime.Text = "00"
        Me.lblKernelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Kernel time"
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Location = New System.Drawing.Point(100, 18)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(19, 13)
        Me.lblPriority.TabIndex = 1
        Me.lblPriority.Text = "00"
        Me.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Priority"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.splitPerformances)
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New System.Drawing.Point(4, 42)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(647, 277)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Performances"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'splitPerformances
        '
        Me.splitPerformances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitPerformances.IsSplitterFixed = True
        Me.splitPerformances.Location = New System.Drawing.Point(3, 3)
        Me.splitPerformances.Name = "splitPerformances"
        Me.splitPerformances.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitPerformances.Panel1
        '
        Me.splitPerformances.Panel1.Controls.Add(Me.graphCPU)
        '
        'splitPerformances.Panel2
        '
        Me.splitPerformances.Panel2.Controls.Add(Me.splitPerformance2)
        Me.splitPerformances.Size = New System.Drawing.Size(641, 271)
        Me.splitPerformances.SplitterDistance = 85
        Me.splitPerformances.SplitterWidth = 1
        Me.splitPerformances.TabIndex = 3
        '
        'graphCPU
        '
        Me.graphCPU.BackColor = System.Drawing.Color.Black
        Me.graphCPU.Color2 = System.Drawing.Color.Olive
        Me.graphCPU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graphCPU.EnableGraph = True
        Me.graphCPU.Fixedheight = True
        Me.graphCPU.GridStep = 10
        Me.graphCPU.Location = New System.Drawing.Point(0, 0)
        Me.graphCPU.Name = "graphCPU"
        Me.graphCPU.ShowSecondGraph = True
        Me.graphCPU.Size = New System.Drawing.Size(641, 85)
        Me.graphCPU.TabIndex = 1
        Me.graphCPU.TabStop = False
        '
        'splitPerformance2
        '
        Me.splitPerformance2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitPerformance2.IsSplitterFixed = True
        Me.splitPerformance2.Location = New System.Drawing.Point(0, 0)
        Me.splitPerformance2.Name = "splitPerformance2"
        Me.splitPerformance2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitPerformance2.Panel1
        '
        Me.splitPerformance2.Panel1.Controls.Add(Me.graphMemory)
        '
        'splitPerformance2.Panel2
        '
        Me.splitPerformance2.Panel2.Controls.Add(Me.graphIO)
        Me.splitPerformance2.Size = New System.Drawing.Size(641, 185)
        Me.splitPerformance2.SplitterDistance = 89
        Me.splitPerformance2.SplitterWidth = 1
        Me.splitPerformance2.TabIndex = 0
        '
        'graphMemory
        '
        Me.graphMemory.BackColor = System.Drawing.Color.Black
        Me.graphMemory.Color = System.Drawing.Color.Red
        Me.graphMemory.Color2 = System.Drawing.Color.Maroon
        Me.graphMemory.Color3 = System.Drawing.Color.LightCoral
        Me.graphMemory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graphMemory.EnableGraph = True
        Me.graphMemory.Fixedheight = False
        Me.graphMemory.GridStep = 10
        Me.graphMemory.Location = New System.Drawing.Point(0, 0)
        Me.graphMemory.Name = "graphMemory"
        Me.graphMemory.ShowSecondGraph = True
        Me.graphMemory.Size = New System.Drawing.Size(641, 89)
        Me.graphMemory.TabIndex = 2
        Me.graphMemory.TabStop = False
        '
        'graphIO
        '
        Me.graphIO.BackColor = System.Drawing.Color.Black
        Me.graphIO.Color = System.Drawing.Color.LimeGreen
        Me.graphIO.Color2 = System.Drawing.Color.Green
        Me.graphIO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graphIO.EnableGraph = True
        Me.graphIO.Fixedheight = False
        Me.graphIO.GridStep = 10
        Me.graphIO.Location = New System.Drawing.Point(0, 0)
        Me.graphIO.Name = "graphIO"
        Me.graphIO.ShowSecondGraph = False
        Me.graphIO.Size = New System.Drawing.Size(641, 95)
        Me.graphIO.TabIndex = 3
        Me.graphIO.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.tabProcessToken)
        Me.TabPage4.ImageIndex = 3
        Me.TabPage4.Location = New System.Drawing.Point(4, 42)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(647, 277)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Token"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'tabProcessToken
        '
        Me.tabProcessToken.Controls.Add(Me.tabProcessTokenPagePrivileges)
        Me.tabProcessToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabProcessToken.Location = New System.Drawing.Point(3, 3)
        Me.tabProcessToken.Name = "tabProcessToken"
        Me.tabProcessToken.SelectedIndex = 0
        Me.tabProcessToken.Size = New System.Drawing.Size(641, 271)
        Me.tabProcessToken.TabIndex = 0
        '
        'tabProcessTokenPagePrivileges
        '
        Me.tabProcessTokenPagePrivileges.Controls.Add(Me.lvPrivileges)
        Me.tabProcessTokenPagePrivileges.Location = New System.Drawing.Point(4, 22)
        Me.tabProcessTokenPagePrivileges.Name = "tabProcessTokenPagePrivileges"
        Me.tabProcessTokenPagePrivileges.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProcessTokenPagePrivileges.Size = New System.Drawing.Size(633, 245)
        Me.tabProcessTokenPagePrivileges.TabIndex = 0
        Me.tabProcessTokenPagePrivileges.Text = "Privileges"
        Me.tabProcessTokenPagePrivileges.UseVisualStyleBackColor = True
        '
        'lvPrivileges
        '
        Me.lvPrivileges.AllowColumnReorder = True
        Me.lvPrivileges.CatchErrors = False
        Me.lvPrivileges.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader50, Me.ColumnHeader51, Me.ColumnHeader52})
        CConnection1.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvPrivileges.ConnectionObj = CConnection1
        Me.lvPrivileges.ContextMenuStrip = Me.menuPrivileges
        Me.lvPrivileges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPrivileges.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPrivileges.FullRowSelect = True
        Me.lvPrivileges.HideSelection = False
        Me.lvPrivileges.Location = New System.Drawing.Point(3, 3)
        Me.lvPrivileges.Name = "lvPrivileges"
        Me.lvPrivileges.OverriddenDoubleBuffered = True
        Me.lvPrivileges.ProcessId = 0
        Me.lvPrivileges.ReorganizeColumns = True
        Me.lvPrivileges.Size = New System.Drawing.Size(627, 239)
        Me.lvPrivileges.TabIndex = 13
        Me.lvPrivileges.UseCompatibleStateImageBehavior = False
        Me.lvPrivileges.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader50
        '
        Me.ColumnHeader50.Text = "Name"
        Me.ColumnHeader50.Width = 159
        '
        'ColumnHeader51
        '
        Me.ColumnHeader51.Text = "Status"
        Me.ColumnHeader51.Width = 100
        '
        'ColumnHeader52
        '
        Me.ColumnHeader52.Text = "Description"
        Me.ColumnHeader52.Width = 319
        '
        'menuPrivileges
        '
        Me.menuPrivileges.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem44, Me.DisableToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.menuPrivileges.Name = "mainMenu"
        Me.menuPrivileges.Size = New System.Drawing.Size(118, 70)
        '
        'ToolStripMenuItem44
        '
        Me.ToolStripMenuItem44.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem44.Image = Global.YAPM.My.Resources.Resources.ok
        Me.ToolStripMenuItem44.Name = "ToolStripMenuItem44"
        Me.ToolStripMenuItem44.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuItem44.Text = "Enable"
        '
        'DisableToolStripMenuItem
        '
        Me.DisableToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.close
        Me.DisableToolStripMenuItem.Name = "DisableToolStripMenuItem"
        Me.DisableToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DisableToolStripMenuItem.Text = "Disable"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.kill
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lvProcMem)
        Me.TabPage5.ImageIndex = 4
        Me.TabPage5.Location = New System.Drawing.Point(4, 42)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(647, 277)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Memory"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lvProcMem
        '
        Me.lvProcMem.AllowColumnReorder = True
        Me.lvProcMem.CatchErrors = False
        Me.lvProcMem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader53, Me.ColumnHeader54, Me.ColumnHeader55, Me.ColumnHeader56, Me.ColumnHeader13})
        CConnection2.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvProcMem.ConnectionObj = CConnection2
        Me.lvProcMem.ContextMenuStrip = Me.menuProcMem
        Me.lvProcMem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvProcMem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProcMem.FullRowSelect = True
        Me.lvProcMem.HideSelection = False
        Me.lvProcMem.Location = New System.Drawing.Point(3, 3)
        Me.lvProcMem.Name = "lvProcMem"
        Me.lvProcMem.OverriddenDoubleBuffered = True
        Me.lvProcMem.ProcessId = 0
        Me.lvProcMem.ReorganizeColumns = True
        Me.lvProcMem.Size = New System.Drawing.Size(641, 271)
        Me.lvProcMem.TabIndex = 14
        Me.lvProcMem.UseCompatibleStateImageBehavior = False
        Me.lvProcMem.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader53
        '
        Me.ColumnHeader53.Text = "Name"
        Me.ColumnHeader53.Width = 170
        '
        'ColumnHeader54
        '
        Me.ColumnHeader54.Text = "Address"
        Me.ColumnHeader54.Width = 82
        '
        'ColumnHeader55
        '
        Me.ColumnHeader55.Text = "Size"
        Me.ColumnHeader55.Width = 64
        '
        'ColumnHeader56
        '
        Me.ColumnHeader56.Text = "Protection"
        Me.ColumnHeader56.Width = 85
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "File"
        Me.ColumnHeader13.Width = 338
        '
        'menuProcMem
        '
        Me.menuProcMem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem49, Me.JumpToPEBAddressToolStripMenuItem, Me.ToolStripMenuItem12, Me.ChooseColumnsToolStripMenuItem4})
        Me.menuProcMem.Name = "menuProc"
        Me.menuProcMem.Size = New System.Drawing.Size(184, 76)
        '
        'ToolStripMenuItem49
        '
        Me.ToolStripMenuItem49.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem49.Image = Global.YAPM.My.Resources.Resources.magnifier
        Me.ToolStripMenuItem49.Name = "ToolStripMenuItem49"
        Me.ToolStripMenuItem49.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem49.Text = "View memory"
        '
        'JumpToPEBAddressToolStripMenuItem
        '
        Me.JumpToPEBAddressToolStripMenuItem.Name = "JumpToPEBAddressToolStripMenuItem"
        Me.JumpToPEBAddressToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.JumpToPEBAddressToolStripMenuItem.Text = "Jump to PEB address"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(180, 6)
        '
        'ChooseColumnsToolStripMenuItem4
        '
        Me.ChooseColumnsToolStripMenuItem4.Name = "ChooseColumnsToolStripMenuItem4"
        Me.ChooseColumnsToolStripMenuItem4.Size = New System.Drawing.Size(183, 22)
        Me.ChooseColumnsToolStripMenuItem4.Text = "Choose columns..."
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.SplitContainerInfoProcess)
        Me.TabPage6.ImageIndex = 5
        Me.TabPage6.Location = New System.Drawing.Point(4, 42)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(647, 277)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Informations"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'SplitContainerInfoProcess
        '
        Me.SplitContainerInfoProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerInfoProcess.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerInfoProcess.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerInfoProcess.Name = "SplitContainerInfoProcess"
        Me.SplitContainerInfoProcess.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerInfoProcess.Panel1
        '
        Me.SplitContainerInfoProcess.Panel1.Controls.Add(Me.cmdRefresh)
        Me.SplitContainerInfoProcess.Panel1.Controls.Add(Me.cmdInfosToClipB)
        '
        'SplitContainerInfoProcess.Panel2
        '
        Me.SplitContainerInfoProcess.Panel2.Controls.Add(Me.rtb)
        Me.SplitContainerInfoProcess.Size = New System.Drawing.Size(641, 271)
        Me.SplitContainerInfoProcess.SplitterDistance = 25
        Me.SplitContainerInfoProcess.TabIndex = 0
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(159, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(85, 24)
        Me.cmdRefresh.TabIndex = 1
        Me.cmdRefresh.Text = "Refresh   "
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdInfosToClipB
        '
        Me.cmdInfosToClipB.Enabled = False
        Me.cmdInfosToClipB.Image = Global.YAPM.My.Resources.Resources.copy16
        Me.cmdInfosToClipB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInfosToClipB.Location = New System.Drawing.Point(3, 0)
        Me.cmdInfosToClipB.Name = "cmdInfosToClipB"
        Me.cmdInfosToClipB.Size = New System.Drawing.Size(150, 24)
        Me.cmdInfosToClipB.TabIndex = 0
        Me.cmdInfosToClipB.Text = "Copy to clipboard"
        Me.cmdInfosToClipB.UseVisualStyleBackColor = True
        '
        'rtb
        '
        Me.rtb.AutoWordSelection = True
        Me.rtb.BackColor = System.Drawing.Color.White
        Me.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb.HideSelection = False
        Me.rtb.Location = New System.Drawing.Point(0, 0)
        Me.rtb.Name = "rtb"
        Me.rtb.ReadOnly = True
        Me.rtb.Size = New System.Drawing.Size(641, 242)
        Me.rtb.TabIndex = 4
        Me.rtb.Text = ""
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.lvProcServices)
        Me.TabPage7.ImageIndex = 7
        Me.TabPage7.Location = New System.Drawing.Point(4, 42)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(647, 277)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Services"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'lvProcServices
        '
        Me.lvProcServices.AllowColumnReorder = True
        Me.lvProcServices.CatchErrors = False
        Me.lvProcServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader19})
        CConnection3.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvProcServices.ConnectionObj = CConnection3
        Me.lvProcServices.ContextMenuStrip = Me.menuProcServ
        Me.lvProcServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvProcServices.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProcServices.FullRowSelect = True
        ListViewGroup1.Header = "Services"
        ListViewGroup1.Name = "gpOther"
        ListViewGroup2.Header = "Search result"
        ListViewGroup2.Name = "gpSearch"
        Me.lvProcServices.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvProcServices.HideSelection = False
        Me.lvProcServices.Location = New System.Drawing.Point(3, 3)
        Me.lvProcServices.Name = "lvProcServices"
        Me.lvProcServices.OverriddenDoubleBuffered = True
        Me.lvProcServices.ProcessId = 0
        Me.lvProcServices.ReorganizeColumns = True
        Me.lvProcServices.ShowAll = False
        Me.lvProcServices.Size = New System.Drawing.Size(641, 271)
        Me.lvProcServices.TabIndex = 2
        Me.lvProcServices.UseCompatibleStateImageBehavior = False
        Me.lvProcServices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 121
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DisplayName"
        Me.ColumnHeader7.Width = 243
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "State"
        Me.ColumnHeader8.Width = 79
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "StartType"
        Me.ColumnHeader9.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ImagePath"
        Me.ColumnHeader10.Width = 250
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "ServiceType"
        Me.ColumnHeader19.Width = 100
        '
        'menuProcServ
        '
        Me.menuProcServ.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceDetailsToolStripMenuItem, Me.ToolStripMenuItem43, Me.ToolStripMenuItem13, Me.PauseToolStripMenuItem14, Me.StopToolStripMenuItem16, Me.ShutdownShutdownToolStripMenuItem, Me.StartToolStripMenuItem17, Me.TypeOfStartToolStripMenuItem18, Me.ReanalyzeToolStripMenuItem, Me.ToolStripSeparator2, Me.FilePropToolStripMenuItem34, Me.OpenDirToolStripMenuItem35, Me.FileDetailsToolStripMenuItem, Me.ToolStripSeparator1, Me.GoogleSearchToolStripMenuItem1, Me.ToolStripMenuItem37, Me.ChooseColumnsToolStripMenuItem5})
        Me.menuProcServ.Name = "menuProc"
        Me.menuProcServ.Size = New System.Drawing.Size(173, 314)
        '
        'ServiceDetailsToolStripMenuItem
        '
        Me.ServiceDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceDetailsToolStripMenuItem.Name = "ServiceDetailsToolStripMenuItem"
        Me.ServiceDetailsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ServiceDetailsToolStripMenuItem.Text = "Service details"
        '
        'ToolStripMenuItem43
        '
        Me.ToolStripMenuItem43.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem43.Image = Global.YAPM.My.Resources.Resources.exe
        Me.ToolStripMenuItem43.Name = "ToolStripMenuItem43"
        Me.ToolStripMenuItem43.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem43.Text = "Select service"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(169, 6)
        '
        'PauseToolStripMenuItem14
        '
        Me.PauseToolStripMenuItem14.Image = Global.YAPM.My.Resources.Resources.control_pause
        Me.PauseToolStripMenuItem14.Name = "PauseToolStripMenuItem14"
        Me.PauseToolStripMenuItem14.Size = New System.Drawing.Size(172, 22)
        Me.PauseToolStripMenuItem14.Text = "Pause"
        '
        'StopToolStripMenuItem16
        '
        Me.StopToolStripMenuItem16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopToolStripMenuItem16.Image = Global.YAPM.My.Resources.Resources.control_stop_square
        Me.StopToolStripMenuItem16.Name = "StopToolStripMenuItem16"
        Me.StopToolStripMenuItem16.Size = New System.Drawing.Size(172, 22)
        Me.StopToolStripMenuItem16.Text = "Stop"
        '
        'ShutdownShutdownToolStripMenuItem
        '
        Me.ShutdownShutdownToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.cross
        Me.ShutdownShutdownToolStripMenuItem.Name = "ShutdownShutdownToolStripMenuItem"
        Me.ShutdownShutdownToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ShutdownShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'StartToolStripMenuItem17
        '
        Me.StartToolStripMenuItem17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartToolStripMenuItem17.Image = Global.YAPM.My.Resources.Resources.control
        Me.StartToolStripMenuItem17.Name = "StartToolStripMenuItem17"
        Me.StartToolStripMenuItem17.Size = New System.Drawing.Size(172, 22)
        Me.StartToolStripMenuItem17.Text = "Start"
        '
        'TypeOfStartToolStripMenuItem18
        '
        Me.TypeOfStartToolStripMenuItem18.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisabledToolStripMenuItem19, Me.AutoToolStripMenuItem20, Me.DemandToolStripMenuItem21})
        Me.TypeOfStartToolStripMenuItem18.Name = "TypeOfStartToolStripMenuItem18"
        Me.TypeOfStartToolStripMenuItem18.Size = New System.Drawing.Size(172, 22)
        Me.TypeOfStartToolStripMenuItem18.Text = "Type of start"
        '
        'DisabledToolStripMenuItem19
        '
        Me.DisabledToolStripMenuItem19.Name = "DisabledToolStripMenuItem19"
        Me.DisabledToolStripMenuItem19.Size = New System.Drawing.Size(137, 22)
        Me.DisabledToolStripMenuItem19.Text = "Disabled"
        '
        'AutoToolStripMenuItem20
        '
        Me.AutoToolStripMenuItem20.Name = "AutoToolStripMenuItem20"
        Me.AutoToolStripMenuItem20.Size = New System.Drawing.Size(137, 22)
        Me.AutoToolStripMenuItem20.Text = "Auto start"
        '
        'DemandToolStripMenuItem21
        '
        Me.DemandToolStripMenuItem21.Name = "DemandToolStripMenuItem21"
        Me.DemandToolStripMenuItem21.Size = New System.Drawing.Size(137, 22)
        Me.DemandToolStripMenuItem21.Text = "On demand"
        '
        'ReanalyzeToolStripMenuItem
        '
        Me.ReanalyzeToolStripMenuItem.Name = "ReanalyzeToolStripMenuItem"
        Me.ReanalyzeToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ReanalyzeToolStripMenuItem.Text = "Reanalyze"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(169, 6)
        '
        'FilePropToolStripMenuItem34
        '
        Me.FilePropToolStripMenuItem34.Image = Global.YAPM.My.Resources.Resources.document_text
        Me.FilePropToolStripMenuItem34.Name = "FilePropToolStripMenuItem34"
        Me.FilePropToolStripMenuItem34.Size = New System.Drawing.Size(172, 22)
        Me.FilePropToolStripMenuItem34.Text = "File properties"
        '
        'OpenDirToolStripMenuItem35
        '
        Me.OpenDirToolStripMenuItem35.Image = Global.YAPM.My.Resources.Resources.folder_open
        Me.OpenDirToolStripMenuItem35.Name = "OpenDirToolStripMenuItem35"
        Me.OpenDirToolStripMenuItem35.Size = New System.Drawing.Size(172, 22)
        Me.OpenDirToolStripMenuItem35.Text = "Open directory"
        '
        'FileDetailsToolStripMenuItem
        '
        Me.FileDetailsToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.magnifier
        Me.FileDetailsToolStripMenuItem.Name = "FileDetailsToolStripMenuItem"
        Me.FileDetailsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.FileDetailsToolStripMenuItem.Text = "File details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'GoogleSearchToolStripMenuItem1
        '
        Me.GoogleSearchToolStripMenuItem1.Image = Global.YAPM.My.Resources.Resources.globe
        Me.GoogleSearchToolStripMenuItem1.Name = "GoogleSearchToolStripMenuItem1"
        Me.GoogleSearchToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.GoogleSearchToolStripMenuItem1.Text = "Internet search"
        '
        'ToolStripMenuItem37
        '
        Me.ToolStripMenuItem37.Name = "ToolStripMenuItem37"
        Me.ToolStripMenuItem37.Size = New System.Drawing.Size(169, 6)
        '
        'ChooseColumnsToolStripMenuItem5
        '
        Me.ChooseColumnsToolStripMenuItem5.Name = "ChooseColumnsToolStripMenuItem5"
        Me.ChooseColumnsToolStripMenuItem5.Size = New System.Drawing.Size(172, 22)
        Me.ChooseColumnsToolStripMenuItem5.Text = "Choose columns..."
        '
        'tabNetwork
        '
        Me.tabNetwork.Controls.Add(Me.lvProcNetwork)
        Me.tabNetwork.ImageIndex = 8
        Me.tabNetwork.Location = New System.Drawing.Point(4, 42)
        Me.tabNetwork.Name = "tabNetwork"
        Me.tabNetwork.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNetwork.Size = New System.Drawing.Size(647, 277)
        Me.tabNetwork.TabIndex = 7
        Me.tabNetwork.Text = "Network"
        Me.tabNetwork.UseVisualStyleBackColor = True
        '
        'lvProcNetwork
        '
        Me.lvProcNetwork.AllowColumnReorder = True
        Me.lvProcNetwork.CatchErrors = False
        Me.lvProcNetwork.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader49, Me.ColumnHeader57, Me.ColumnHeader58, Me.ColumnHeader59})
        CConnection4.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvProcNetwork.ConnectionObj = CConnection4
        Me.lvProcNetwork.ContextMenuStrip = Me.menuNetwork
        Me.lvProcNetwork.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvProcNetwork.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProcNetwork.FullRowSelect = True
        Me.lvProcNetwork.HideSelection = False
        Me.lvProcNetwork.Location = New System.Drawing.Point(3, 3)
        Me.lvProcNetwork.Name = "lvProcNetwork"
        Me.lvProcNetwork.OverriddenDoubleBuffered = True
        Me.lvProcNetwork.ProcessId = Nothing
        Me.lvProcNetwork.ReorganizeColumns = True
        Me.lvProcNetwork.ShowAllPid = False
        Me.lvProcNetwork.Size = New System.Drawing.Size(641, 271)
        Me.lvProcNetwork.TabIndex = 21
        Me.lvProcNetwork.UseCompatibleStateImageBehavior = False
        Me.lvProcNetwork.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader49
        '
        Me.ColumnHeader49.Text = "Local"
        Me.ColumnHeader49.Width = 210
        '
        'ColumnHeader57
        '
        Me.ColumnHeader57.Text = "Remote"
        Me.ColumnHeader57.Width = 200
        '
        'ColumnHeader58
        '
        Me.ColumnHeader58.Text = "Protocol"
        '
        'ColumnHeader59
        '
        Me.ColumnHeader59.Text = "State"
        Me.ColumnHeader59.Width = 150
        '
        'menuNetwork
        '
        Me.menuNetwork.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem15})
        Me.menuNetwork.Name = "menuProc"
        Me.menuNetwork.Size = New System.Drawing.Size(173, 26)
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem15.Text = "Choose columns..."
        '
        'TabPageString
        '
        Me.TabPageString.Controls.Add(Me.SplitContainerStrings)
        Me.TabPageString.ImageKey = "font"
        Me.TabPageString.Location = New System.Drawing.Point(4, 42)
        Me.TabPageString.Name = "TabPageString"
        Me.TabPageString.Size = New System.Drawing.Size(647, 277)
        Me.TabPageString.TabIndex = 8
        Me.TabPageString.Text = "Strings"
        Me.TabPageString.UseVisualStyleBackColor = True
        '
        'SplitContainerStrings
        '
        Me.SplitContainerStrings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerStrings.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerStrings.Name = "SplitContainerStrings"
        Me.SplitContainerStrings.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerStrings.Panel1
        '
        Me.SplitContainerStrings.Panel1.Controls.Add(Me.lvProcString)
        '
        'SplitContainerStrings.Panel2
        '
        Me.SplitContainerStrings.Panel2.Controls.Add(Me.cmdProcSearchR)
        Me.SplitContainerStrings.Panel2.Controls.Add(Me.cmdProcSearchL)
        Me.SplitContainerStrings.Panel2.Controls.Add(Me.pgbString)
        Me.SplitContainerStrings.Panel2.Controls.Add(Me.Label28)
        Me.SplitContainerStrings.Panel2.Controls.Add(Me.txtSearchProcString)
        Me.SplitContainerStrings.Panel2.Controls.Add(Me.cmdProcStringSave)
        Me.SplitContainerStrings.Panel2.Controls.Add(Me.optProcStringMemory)
        Me.SplitContainerStrings.Panel2.Controls.Add(Me.optProcStringImage)
        Me.SplitContainerStrings.Size = New System.Drawing.Size(647, 277)
        Me.SplitContainerStrings.SplitterDistance = 245
        Me.SplitContainerStrings.TabIndex = 0
        '
        'lvProcString
        '
        Me.lvProcString.AllowColumnReorder = True
        Me.lvProcString.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader76, Me.ColumnHeader77})
        Me.lvProcString.ContextMenuStrip = Me.menuString
        Me.lvProcString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvProcString.FullRowSelect = True
        ListViewGroup3.Header = "Strings"
        ListViewGroup3.Name = "gpOther"
        ListViewGroup4.Header = "Search result"
        ListViewGroup4.Name = "gpSearch"
        Me.lvProcString.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup3, ListViewGroup4})
        Me.lvProcString.HideSelection = False
        Me.lvProcString.Location = New System.Drawing.Point(0, 0)
        Me.lvProcString.MultiSelect = False
        Me.lvProcString.Name = "lvProcString"
        Me.lvProcString.OverriddenDoubleBuffered = True
        Me.lvProcString.Size = New System.Drawing.Size(647, 245)
        Me.lvProcString.TabIndex = 22
        Me.lvProcString.UseCompatibleStateImageBehavior = False
        Me.lvProcString.View = System.Windows.Forms.View.Details
        Me.lvProcString.VirtualMode = True
        '
        'ColumnHeader76
        '
        Me.ColumnHeader76.Text = "Position"
        Me.ColumnHeader76.Width = 149
        '
        'ColumnHeader77
        '
        Me.ColumnHeader77.Text = "String"
        Me.ColumnHeader77.Width = 447
        '
        'menuString
        '
        Me.menuString.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuViewMemoryString})
        Me.menuString.Name = "menuProc"
        Me.menuString.Size = New System.Drawing.Size(153, 26)
        '
        'menuViewMemoryString
        '
        Me.menuViewMemoryString.Enabled = False
        Me.menuViewMemoryString.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuViewMemoryString.Image = Global.YAPM.My.Resources.Resources.magnifier
        Me.menuViewMemoryString.Name = "menuViewMemoryString"
        Me.menuViewMemoryString.Size = New System.Drawing.Size(152, 22)
        Me.menuViewMemoryString.Text = "View memory"
        '
        'cmdProcSearchR
        '
        Me.cmdProcSearchR.Image = Global.YAPM.My.Resources.Resources.arrow_000_medium
        Me.cmdProcSearchR.Location = New System.Drawing.Point(499, 1)
        Me.cmdProcSearchR.Name = "cmdProcSearchR"
        Me.cmdProcSearchR.Size = New System.Drawing.Size(19, 23)
        Me.cmdProcSearchR.TabIndex = 29
        Me.cmdProcSearchR.UseVisualStyleBackColor = True
        '
        'cmdProcSearchL
        '
        Me.cmdProcSearchL.Image = Global.YAPM.My.Resources.Resources.arrow_180_medium
        Me.cmdProcSearchL.Location = New System.Drawing.Point(476, 1)
        Me.cmdProcSearchL.Name = "cmdProcSearchL"
        Me.cmdProcSearchL.Size = New System.Drawing.Size(19, 23)
        Me.cmdProcSearchL.TabIndex = 28
        Me.cmdProcSearchL.UseVisualStyleBackColor = True
        '
        'pgbString
        '
        Me.pgbString.Location = New System.Drawing.Point(248, 1)
        Me.pgbString.Name = "pgbString"
        Me.pgbString.Size = New System.Drawing.Size(102, 23)
        Me.pgbString.TabIndex = 26
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(365, 6)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(41, 13)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "Search"
        '
        'txtSearchProcString
        '
        Me.txtSearchProcString.Location = New System.Drawing.Point(410, 2)
        Me.txtSearchProcString.Name = "txtSearchProcString"
        Me.txtSearchProcString.Size = New System.Drawing.Size(60, 22)
        Me.txtSearchProcString.TabIndex = 27
        '
        'cmdProcStringSave
        '
        Me.cmdProcStringSave.Image = Global.YAPM.My.Resources.Resources._096
        Me.cmdProcStringSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProcStringSave.Location = New System.Drawing.Point(140, 1)
        Me.cmdProcStringSave.Name = "cmdProcStringSave"
        Me.cmdProcStringSave.Size = New System.Drawing.Size(91, 23)
        Me.cmdProcStringSave.TabIndex = 25
        Me.cmdProcStringSave.Text = "Save..."
        Me.cmdProcStringSave.UseVisualStyleBackColor = True
        '
        'optProcStringMemory
        '
        Me.optProcStringMemory.AutoSize = True
        Me.optProcStringMemory.Location = New System.Drawing.Point(63, 4)
        Me.optProcStringMemory.Name = "optProcStringMemory"
        Me.optProcStringMemory.Size = New System.Drawing.Size(66, 17)
        Me.optProcStringMemory.TabIndex = 24
        Me.optProcStringMemory.Text = "Memory"
        Me.optProcStringMemory.UseVisualStyleBackColor = True
        '
        'optProcStringImage
        '
        Me.optProcStringImage.AutoSize = True
        Me.optProcStringImage.Checked = True
        Me.optProcStringImage.Location = New System.Drawing.Point(3, 4)
        Me.optProcStringImage.Name = "optProcStringImage"
        Me.optProcStringImage.Size = New System.Drawing.Size(56, 17)
        Me.optProcStringImage.TabIndex = 23
        Me.optProcStringImage.TabStop = True
        Me.optProcStringImage.Text = "Image"
        Me.optProcStringImage.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.lvProcEnv)
        Me.TabPage9.ImageIndex = 10
        Me.TabPage9.Location = New System.Drawing.Point(4, 42)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(647, 277)
        Me.TabPage9.TabIndex = 9
        Me.TabPage9.Text = "Environment"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'lvProcEnv
        '
        Me.lvProcEnv.AllowColumnReorder = True
        Me.lvProcEnv.CatchErrors = False
        Me.lvProcEnv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader60, Me.ColumnHeader61})
        CConnection5.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvProcEnv.ConnectionObj = CConnection5
        Me.lvProcEnv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvProcEnv.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProcEnv.FullRowSelect = True
        ListViewGroup5.Header = "Strings"
        ListViewGroup5.Name = "gpOther"
        ListViewGroup6.Header = "Search result"
        ListViewGroup6.Name = "gpSearch"
        Me.lvProcEnv.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup5, ListViewGroup6})
        Me.lvProcEnv.HideSelection = False
        Me.lvProcEnv.Location = New System.Drawing.Point(0, 0)
        Me.lvProcEnv.Name = "lvProcEnv"
        Me.lvProcEnv.OverriddenDoubleBuffered = True
        Me.lvProcEnv.Peb = 0
        Me.lvProcEnv.ProcessId = 0
        Me.lvProcEnv.ReorganizeColumns = True
        Me.lvProcEnv.Size = New System.Drawing.Size(647, 277)
        Me.lvProcEnv.TabIndex = 30
        Me.lvProcEnv.UseCompatibleStateImageBehavior = False
        Me.lvProcEnv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader60
        '
        Me.ColumnHeader60.Text = "Variable"
        Me.ColumnHeader60.Width = 169
        '
        'ColumnHeader61
        '
        Me.ColumnHeader61.Text = "Value"
        Me.ColumnHeader61.Width = 431
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.lvModules)
        Me.TabPage10.ImageKey = "dll"
        Me.TabPage10.Location = New System.Drawing.Point(4, 42)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(647, 277)
        Me.TabPage10.TabIndex = 10
        Me.TabPage10.Text = "Modules"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'lvModules
        '
        Me.lvModules.AllowColumnReorder = True
        Me.lvModules.CatchErrors = False
        Me.lvModules.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader29, Me.ColumnHeader43, Me.ColumnHeader44, Me.ColumnHeader45, Me.ColumnHeader46, Me.ColumnHeader1})
        CConnection6.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvModules.ConnectionObj = CConnection6
        Me.lvModules.ContextMenuStrip = Me.menuModule
        Me.lvModules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvModules.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvModules.FullRowSelect = True
        ListViewGroup7.Header = "Modules"
        ListViewGroup7.Name = "gpOther"
        ListViewGroup8.Header = "Search result"
        ListViewGroup8.Name = "gpSearchResults"
        Me.lvModules.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup7, ListViewGroup8})
        Me.lvModules.HideSelection = False
        Me.lvModules.Location = New System.Drawing.Point(0, 0)
        Me.lvModules.Name = "lvModules"
        Me.lvModules.OverriddenDoubleBuffered = True
        Me.lvModules.ProcessId = Nothing
        Me.lvModules.ReorganizeColumns = True
        Me.lvModules.Size = New System.Drawing.Size(647, 277)
        Me.lvModules.TabIndex = 31
        Me.lvModules.UseCompatibleStateImageBehavior = False
        Me.lvModules.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Name"
        Me.ColumnHeader29.Width = 90
        '
        'ColumnHeader43
        '
        Me.ColumnHeader43.DisplayIndex = 2
        Me.ColumnHeader43.Text = "Version"
        Me.ColumnHeader43.Width = 85
        '
        'ColumnHeader44
        '
        Me.ColumnHeader44.DisplayIndex = 3
        Me.ColumnHeader44.Text = "Description"
        Me.ColumnHeader44.Width = 210
        '
        'ColumnHeader45
        '
        Me.ColumnHeader45.DisplayIndex = 4
        Me.ColumnHeader45.Text = "CompanyName"
        Me.ColumnHeader45.Width = 150
        '
        'ColumnHeader46
        '
        Me.ColumnHeader46.DisplayIndex = 5
        Me.ColumnHeader46.Text = "Path"
        Me.ColumnHeader46.Width = 300
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 1
        Me.ColumnHeader1.Text = "Address"
        Me.ColumnHeader1.Width = 80
        '
        'menuModule
        '
        Me.menuModule.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowFileDetailsToolStripMenuItem, Me.OpenFirectoryToolStripMenuItem, Me.PropertiesToolStripMenuItem, Me.ToolStripMenuItem36, Me.ViewDependenciesToolStripMenuItem, Me.ToolStripMenuItem39, Me.GoogleSearchToolStripMenuItem2, Me.ToolStripMenuItem1, Me.ViewMemoryToolStripMenuItem, Me.ToolStripMenuItem11, Me.ChooseColumnsToolStripMenuItem3})
        Me.menuModule.Name = "menuProc"
        Me.menuModule.Size = New System.Drawing.Size(176, 220)
        '
        'ShowFileDetailsToolStripMenuItem
        '
        Me.ShowFileDetailsToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.magnifier
        Me.ShowFileDetailsToolStripMenuItem.Name = "ShowFileDetailsToolStripMenuItem"
        Me.ShowFileDetailsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ShowFileDetailsToolStripMenuItem.Text = "Show file details"
        '
        'OpenFirectoryToolStripMenuItem
        '
        Me.OpenFirectoryToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.folder_open
        Me.OpenFirectoryToolStripMenuItem.Name = "OpenFirectoryToolStripMenuItem"
        Me.OpenFirectoryToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OpenFirectoryToolStripMenuItem.Text = "Open directory"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.document_text
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PropertiesToolStripMenuItem.Text = "File properties"
        '
        'ToolStripMenuItem36
        '
        Me.ToolStripMenuItem36.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem36.Image = Global.YAPM.My.Resources.Resources.cross
        Me.ToolStripMenuItem36.Name = "ToolStripMenuItem36"
        Me.ToolStripMenuItem36.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem36.Text = "Unload module"
        '
        'ToolStripMenuItem39
        '
        Me.ToolStripMenuItem39.Name = "ToolStripMenuItem39"
        Me.ToolStripMenuItem39.Size = New System.Drawing.Size(172, 6)
        '
        'GoogleSearchToolStripMenuItem2
        '
        Me.GoogleSearchToolStripMenuItem2.Image = Global.YAPM.My.Resources.Resources.globe
        Me.GoogleSearchToolStripMenuItem2.Name = "GoogleSearchToolStripMenuItem2"
        Me.GoogleSearchToolStripMenuItem2.Size = New System.Drawing.Size(175, 22)
        Me.GoogleSearchToolStripMenuItem2.Text = "Internet search"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(172, 6)
        '
        'ViewMemoryToolStripMenuItem
        '
        Me.ViewMemoryToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.magnifier
        Me.ViewMemoryToolStripMenuItem.Name = "ViewMemoryToolStripMenuItem"
        Me.ViewMemoryToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ViewMemoryToolStripMenuItem.Text = "View memory"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(172, 6)
        '
        'ChooseColumnsToolStripMenuItem3
        '
        Me.ChooseColumnsToolStripMenuItem3.Name = "ChooseColumnsToolStripMenuItem3"
        Me.ChooseColumnsToolStripMenuItem3.Size = New System.Drawing.Size(175, 22)
        Me.ChooseColumnsToolStripMenuItem3.Text = "Choose columns..."
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.lvThreads)
        Me.TabPage11.ImageKey = "thread"
        Me.TabPage11.Location = New System.Drawing.Point(4, 42)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(647, 277)
        Me.TabPage11.TabIndex = 11
        Me.TabPage11.Text = "Threads"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'lvThreads
        '
        Me.lvThreads.AllowColumnReorder = True
        Me.lvThreads.CatchErrors = False
        Me.lvThreads.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader32, Me.ColumnHeader12, Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader38, Me.ColumnHeader6, Me.ColumnHeader11})
        CConnection7.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvThreads.ConnectionObj = CConnection7
        Me.lvThreads.ContextMenuStrip = Me.menuThread
        Me.lvThreads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvThreads.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvThreads.FullRowSelect = True
        ListViewGroup9.Header = "Threads"
        ListViewGroup9.Name = "gpOther"
        ListViewGroup10.Header = "Search results"
        ListViewGroup10.Name = "gpSearchResults"
        Me.lvThreads.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup9, ListViewGroup10})
        Me.lvThreads.HideSelection = False
        Me.lvThreads.Location = New System.Drawing.Point(0, 0)
        Me.lvThreads.Name = "lvThreads"
        Me.lvThreads.OverriddenDoubleBuffered = True
        Me.lvThreads.ProcessId = Nothing
        Me.lvThreads.ReorganizeColumns = True
        Me.lvThreads.Size = New System.Drawing.Size(647, 277)
        Me.lvThreads.TabIndex = 4
        Me.lvThreads.UseCompatibleStateImageBehavior = False
        Me.lvThreads.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "Id"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ContextSwitchDelta"
        Me.ColumnHeader12.Width = 118
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "Priority"
        Me.ColumnHeader34.Width = 100
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "State"
        Me.ColumnHeader35.Width = 70
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "WaitReason"
        Me.ColumnHeader36.Width = 100
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "CreateTime"
        Me.ColumnHeader37.Width = 119
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "TotalTime"
        Me.ColumnHeader38.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "StartAddress"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ContextSwitchCount"
        Me.ColumnHeader11.Width = 200
        '
        'menuThread
        '
        Me.menuThread.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem23, Me.ToolStripMenuItem24, Me.ToolStripMenuItem25, Me.ToolStripMenuItem26, Me.ToolStripMenuItem33, Me.ToolStripMenuItem8, Me.ChooseColumnsToolStripMenuItem})
        Me.menuThread.Name = "menuProc"
        Me.menuThread.Size = New System.Drawing.Size(173, 142)
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem23.Image = Global.YAPM.My.Resources.Resources.cross
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem23.Text = "Terminate"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Image = Global.YAPM.My.Resources.Resources.control_pause
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem24.Text = "Suspend"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Image = Global.YAPM.My.Resources.Resources.control
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem25.Text = "Resume"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem27, Me.LowestToolStripMenuItem, Me.ToolStripMenuItem28, Me.ToolStripMenuItem29, Me.ToolStripMenuItem30, Me.ToolStripMenuItem31, Me.ToolStripMenuItem32})
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem26.Text = "Priotiy"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Image = CType(resources.GetObject("ToolStripMenuItem27.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem27.Text = "Idle"
        '
        'LowestToolStripMenuItem
        '
        Me.LowestToolStripMenuItem.Image = CType(resources.GetObject("LowestToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LowestToolStripMenuItem.Name = "LowestToolStripMenuItem"
        Me.LowestToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.LowestToolStripMenuItem.Text = "Lowest"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Image = CType(resources.GetObject("ToolStripMenuItem28.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem28.Text = "Below Normal"
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.Image = CType(resources.GetObject("ToolStripMenuItem29.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem29.Text = "Normal"
        '
        'ToolStripMenuItem30
        '
        Me.ToolStripMenuItem30.Image = CType(resources.GetObject("ToolStripMenuItem30.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem30.Name = "ToolStripMenuItem30"
        Me.ToolStripMenuItem30.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem30.Text = "Above Normal"
        '
        'ToolStripMenuItem31
        '
        Me.ToolStripMenuItem31.Image = CType(resources.GetObject("ToolStripMenuItem31.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem31.Name = "ToolStripMenuItem31"
        Me.ToolStripMenuItem31.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem31.Text = "Highest"
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.Image = CType(resources.GetObject("ToolStripMenuItem32.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem32.Text = "Time Critical"
        '
        'ToolStripMenuItem33
        '
        Me.ToolStripMenuItem33.Name = "ToolStripMenuItem33"
        Me.ToolStripMenuItem33.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem33.Text = "Set affinity..."
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(169, 6)
        '
        'ChooseColumnsToolStripMenuItem
        '
        Me.ChooseColumnsToolStripMenuItem.Name = "ChooseColumnsToolStripMenuItem"
        Me.ChooseColumnsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ChooseColumnsToolStripMenuItem.Text = "Choose columns..."
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.lvWindows)
        Me.TabPage12.ImageKey = "windows"
        Me.TabPage12.Location = New System.Drawing.Point(4, 42)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(647, 277)
        Me.TabPage12.TabIndex = 12
        Me.TabPage12.Text = "Windows"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'lvWindows
        '
        Me.lvWindows.AllowColumnReorder = True
        Me.lvWindows.CatchErrors = False
        Me.lvWindows.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader30, Me.ColumnHeader39, Me.ColumnHeader40, Me.ColumnHeader41, Me.ColumnHeader42})
        CConnection8.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvWindows.ConnectionObj = CConnection8
        Me.lvWindows.ContextMenuStrip = Me.menuWindow
        Me.lvWindows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvWindows.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvWindows.FullRowSelect = True
        ListViewGroup11.Header = "Windows"
        ListViewGroup11.Name = "gpOther"
        ListViewGroup12.Header = "Search results"
        ListViewGroup12.Name = "gpSearchResults"
        Me.lvWindows.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup11, ListViewGroup12})
        Me.lvWindows.HideSelection = False
        Me.lvWindows.Location = New System.Drawing.Point(0, 0)
        Me.lvWindows.Name = "lvWindows"
        Me.lvWindows.OverriddenDoubleBuffered = True
        Me.lvWindows.ProcessId = Nothing
        Me.lvWindows.ReorganizeColumns = True
        Me.lvWindows.ShowAllPid = False
        Me.lvWindows.ShowUnNamed = False
        Me.lvWindows.Size = New System.Drawing.Size(647, 277)
        Me.lvWindows.TabIndex = 33
        Me.lvWindows.UseCompatibleStateImageBehavior = False
        Me.lvWindows.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Id"
        Me.ColumnHeader30.Width = 100
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Text = "Caption"
        Me.ColumnHeader39.Width = 350
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Text = "IsTask"
        '
        'ColumnHeader41
        '
        Me.ColumnHeader41.Text = "Enabled"
        '
        'ColumnHeader42
        '
        Me.ColumnHeader42.Text = "Visible"
        '
        'menuWindow
        '
        Me.menuWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ShowUnnamedWindowsToolStripMenuItem, Me.HideToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ToolStripMenuItem2, Me.BringToFrontToolStripMenuItem, Me.DoNotBringToFrontToolStripMenuItem, Me.SetAsActiveWindowToolStripMenuItem, Me.SetAsForegroundWindowToolStripMenuItem, Me.ToolStripMenuItem3, Me.MinimizeToolStripMenuItem, Me.MaximizeToolStripMenuItem, Me.PositionSizeToolStripMenuItem, Me.ToolStripMenuItem4, Me.EnableToolStripMenuItem, Me.DisableToolStripMenuItem1, Me.ToolStripMenuItem10, Me.ChooseColumnsToolStripMenuItem2})
        Me.menuWindow.Name = "menuProc"
        Me.menuWindow.Size = New System.Drawing.Size(213, 336)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToolStripMenuItem.Image = CType(resources.GetObject("ShowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ShowUnnamedWindowsToolStripMenuItem
        '
        Me.ShowUnnamedWindowsToolStripMenuItem.Checked = True
        Me.ShowUnnamedWindowsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowUnnamedWindowsToolStripMenuItem.Name = "ShowUnnamedWindowsToolStripMenuItem"
        Me.ShowUnnamedWindowsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ShowUnnamedWindowsToolStripMenuItem.Text = "Show unnamed windows"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.cross
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(209, 6)
        '
        'BringToFrontToolStripMenuItem
        '
        Me.BringToFrontToolStripMenuItem.Name = "BringToFrontToolStripMenuItem"
        Me.BringToFrontToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.BringToFrontToolStripMenuItem.Text = "Bring to front"
        '
        'DoNotBringToFrontToolStripMenuItem
        '
        Me.DoNotBringToFrontToolStripMenuItem.Name = "DoNotBringToFrontToolStripMenuItem"
        Me.DoNotBringToFrontToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DoNotBringToFrontToolStripMenuItem.Text = "Do not bring to front"
        '
        'SetAsActiveWindowToolStripMenuItem
        '
        Me.SetAsActiveWindowToolStripMenuItem.Name = "SetAsActiveWindowToolStripMenuItem"
        Me.SetAsActiveWindowToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SetAsActiveWindowToolStripMenuItem.Text = "Set as active window"
        '
        'SetAsForegroundWindowToolStripMenuItem
        '
        Me.SetAsForegroundWindowToolStripMenuItem.Name = "SetAsForegroundWindowToolStripMenuItem"
        Me.SetAsForegroundWindowToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SetAsForegroundWindowToolStripMenuItem.Text = "Set as foreground window"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(209, 6)
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'PositionSizeToolStripMenuItem
        '
        Me.PositionSizeToolStripMenuItem.Name = "PositionSizeToolStripMenuItem"
        Me.PositionSizeToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.PositionSizeToolStripMenuItem.Text = "Position and size"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(209, 6)
        '
        'EnableToolStripMenuItem
        '
        Me.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem"
        Me.EnableToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.EnableToolStripMenuItem.Text = "Enable"
        '
        'DisableToolStripMenuItem1
        '
        Me.DisableToolStripMenuItem1.Image = Global.YAPM.My.Resources.Resources.close
        Me.DisableToolStripMenuItem1.Name = "DisableToolStripMenuItem1"
        Me.DisableToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.DisableToolStripMenuItem1.Text = "Disable"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(209, 6)
        '
        'ChooseColumnsToolStripMenuItem2
        '
        Me.ChooseColumnsToolStripMenuItem2.Name = "ChooseColumnsToolStripMenuItem2"
        Me.ChooseColumnsToolStripMenuItem2.Size = New System.Drawing.Size(212, 22)
        Me.ChooseColumnsToolStripMenuItem2.Text = "Choose columns..."
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.lvHandles)
        Me.TabPage13.ImageKey = "handle"
        Me.TabPage13.Location = New System.Drawing.Point(4, 42)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Size = New System.Drawing.Size(647, 277)
        Me.TabPage13.TabIndex = 13
        Me.TabPage13.Text = "Handles"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'lvHandles
        '
        Me.lvHandles.AllowColumnReorder = True
        Me.lvHandles.CatchErrors = False
        Me.lvHandles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader15})
        CConnection9.ConnectionType = CoreFunc.cConnection.TypeOfConnection.LocalConnection
        Me.lvHandles.ConnectionObj = CConnection9
        Me.lvHandles.ContextMenuStrip = Me.menuHandles
        Me.lvHandles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvHandles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvHandles.FullRowSelect = True
        ListViewGroup13.Header = "Handles"
        ListViewGroup13.Name = "gpOther"
        ListViewGroup14.Header = "Search result"
        ListViewGroup14.Name = "gpSearch"
        Me.lvHandles.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup13, ListViewGroup14})
        Me.lvHandles.HideSelection = False
        Me.lvHandles.Location = New System.Drawing.Point(0, 0)
        Me.lvHandles.Name = "lvHandles"
        Me.lvHandles.OverriddenDoubleBuffered = True
        Me.lvHandles.ProcessId = Nothing
        Me.lvHandles.ReorganizeColumns = True
        Me.lvHandles.ShowUnnamed = False
        Me.lvHandles.Size = New System.Drawing.Size(647, 277)
        Me.lvHandles.TabIndex = 34
        Me.lvHandles.UseCompatibleStateImageBehavior = False
        Me.lvHandles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Type"
        Me.ColumnHeader24.Width = 80
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Name"
        Me.ColumnHeader25.Width = 400
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "HandleCount"
        Me.ColumnHeader26.Width = 70
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "PointerCount"
        Me.ColumnHeader27.Width = 70
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "ObjectCount"
        Me.ColumnHeader28.Width = 70
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Handle"
        Me.ColumnHeader15.Width = 70
        '
        'menuHandles
        '
        Me.menuHandles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem22, Me.ToolStripMenuItem5, Me.ShowUnnamedHandlesToolStripMenuItem, Me.ToolStripMenuItem9, Me.ChooseColumnsToolStripMenuItem1})
        Me.menuHandles.Name = "menuProc"
        Me.menuHandles.Size = New System.Drawing.Size(202, 82)
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem22.Image = Global.YAPM.My.Resources.Resources.cross
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(201, 22)
        Me.ToolStripMenuItem22.Text = "Close item"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(198, 6)
        '
        'ShowUnnamedHandlesToolStripMenuItem
        '
        Me.ShowUnnamedHandlesToolStripMenuItem.Name = "ShowUnnamedHandlesToolStripMenuItem"
        Me.ShowUnnamedHandlesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ShowUnnamedHandlesToolStripMenuItem.Text = "Show unnamed handles"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(198, 6)
        '
        'ChooseColumnsToolStripMenuItem1
        '
        Me.ChooseColumnsToolStripMenuItem1.Name = "ChooseColumnsToolStripMenuItem1"
        Me.ChooseColumnsToolStripMenuItem1.Size = New System.Drawing.Size(201, 22)
        Me.ChooseColumnsToolStripMenuItem1.Text = "Choose columns..."
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.SplitContainerLog)
        Me.TabPage14.ImageIndex = 6
        Me.TabPage14.Location = New System.Drawing.Point(4, 42)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Size = New System.Drawing.Size(647, 277)
        Me.TabPage14.TabIndex = 14
        Me.TabPage14.Text = "Log"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'SplitContainerLog
        '
        Me.SplitContainerLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerLog.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerLog.IsSplitterFixed = True
        Me.SplitContainerLog.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerLog.Name = "SplitContainerLog"
        Me.SplitContainerLog.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerLog.Panel1
        '
        Me.SplitContainerLog.Panel1.Controls.Add(Me.cmdLogOptions)
        Me.SplitContainerLog.Panel1.Controls.Add(Me.cmdSave)
        Me.SplitContainerLog.Panel1.Controls.Add(Me.cmdClearLog)
        Me.SplitContainerLog.Panel1.Controls.Add(Me.chkLog)
        '
        'SplitContainerLog.Panel2
        '
        Me.SplitContainerLog.Panel2.Controls.Add(Me.lvLog)
        Me.SplitContainerLog.Size = New System.Drawing.Size(647, 277)
        Me.SplitContainerLog.SplitterDistance = 25
        Me.SplitContainerLog.TabIndex = 0
        '
        'cmdLogOptions
        '
        Me.cmdLogOptions.Location = New System.Drawing.Point(262, 1)
        Me.cmdLogOptions.Name = "cmdLogOptions"
        Me.cmdLogOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdLogOptions.TabIndex = 5
        Me.cmdLogOptions.Text = "Options..."
        Me.cmdLogOptions.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(181, 1)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save log..."
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClearLog
        '
        Me.cmdClearLog.Location = New System.Drawing.Point(100, 1)
        Me.cmdClearLog.Name = "cmdClearLog"
        Me.cmdClearLog.Size = New System.Drawing.Size(75, 23)
        Me.cmdClearLog.TabIndex = 1
        Me.cmdClearLog.Text = "Clear log"
        Me.cmdClearLog.UseVisualStyleBackColor = True
        '
        'chkLog
        '
        Me.chkLog.AutoSize = True
        Me.chkLog.Location = New System.Drawing.Point(8, 4)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(86, 17)
        Me.chkLog.TabIndex = 0
        Me.chkLog.Text = "Activate log"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'lvLog
        '
        Me.lvLog.AllowColumnReorder = True
        Me.lvLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader4})
        Me.lvLog.ContextMenuStrip = Me.menuString
        Me.lvLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLog.FullRowSelect = True
        ListViewGroup15.Header = "Strings"
        ListViewGroup15.Name = "gpOther"
        ListViewGroup16.Header = "Search result"
        ListViewGroup16.Name = "gpSearch"
        Me.lvLog.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup15, ListViewGroup16})
        Me.lvLog.HideSelection = False
        Me.lvLog.Location = New System.Drawing.Point(0, 0)
        Me.lvLog.MultiSelect = False
        Me.lvLog.Name = "lvLog"
        Me.lvLog.OverriddenDoubleBuffered = True
        Me.lvLog.Size = New System.Drawing.Size(647, 248)
        Me.lvLog.TabIndex = 24
        Me.lvLog.UseCompatibleStateImageBehavior = False
        Me.lvLog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date & Time"
        Me.ColumnHeader2.Width = 172
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Type"
        Me.ColumnHeader5.Width = 69
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 400
        '
        'TabPage15
        '
        Me.TabPage15.Controls.Add(Me.containerHistory)
        Me.TabPage15.Controls.Add(Me.lstHistoryCat)
        Me.TabPage15.ImageIndex = 2
        Me.TabPage15.Location = New System.Drawing.Point(4, 42)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Size = New System.Drawing.Size(647, 277)
        Me.TabPage15.TabIndex = 15
        Me.TabPage15.Text = "History"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'containerHistory
        '
        Me.containerHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.containerHistory.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.containerHistory.IsSplitterFixed = True
        Me.containerHistory.Location = New System.Drawing.Point(208, 0)
        Me.containerHistory.Name = "containerHistory"
        Me.containerHistory.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'containerHistory.Panel1
        '
        Me.containerHistory.Panel1.Controls.Add(Me.Label2)
        Me.containerHistory.Size = New System.Drawing.Size(439, 277)
        Me.containerHistory.SplitterDistance = 25
        Me.containerHistory.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "  Check items to see history graph"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstHistoryCat
        '
        Me.lstHistoryCat.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstHistoryCat.FormattingEnabled = True
        Me.lstHistoryCat.Items.AddRange(New Object() {"CpuUsage", "AverageCpuUsage", "KernelCpuTime", "UserCpuTime", "TotalCpuTime", "GdiObjects", "UserObjects", "WorkingSet", "PeakWorkingSet", "PageFaultCount", "PagefileUsage", "PeakPagefileUsage", "QuotaPeakPagedPoolUsage", "QuotaPagedPoolUsage", "QuotaPeakNonPagedPoolUsage", "QuotaNonPagedPoolUsage", "ReadOperationCount", "WriteOperationCount", "OtherOperationCount", "ReadTransferCount", "WriteTransferCount", "OtherTransferCount", "ReadOperationCountDelta", "WriteOperationCountDelta", "OtherOperationCountDelta", "ReadTransferCountDelta", "WriteTransferCountDelta", "OtherTransferCountDelta"})
        Me.lstHistoryCat.Location = New System.Drawing.Point(0, 0)
        Me.lstHistoryCat.Name = "lstHistoryCat"
        Me.lstHistoryCat.Size = New System.Drawing.Size(208, 276)
        Me.lstHistoryCat.TabIndex = 0
        '
        'imgProcessTab
        '
        Me.imgProcessTab.ImageStream = CType(resources.GetObject("imgProcessTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgProcessTab.TransparentColor = System.Drawing.Color.Transparent
        Me.imgProcessTab.Images.SetKeyName(0, "exe")
        Me.imgProcessTab.Images.SetKeyName(1, "stats")
        Me.imgProcessTab.Images.SetKeyName(2, "monitor.png")
        Me.imgProcessTab.Images.SetKeyName(3, "locked")
        Me.imgProcessTab.Images.SetKeyName(4, "memory")
        Me.imgProcessTab.Images.SetKeyName(5, "exe2")
        Me.imgProcessTab.Images.SetKeyName(6, "document_text.png")
        Me.imgProcessTab.Images.SetKeyName(7, "service")
        Me.imgProcessTab.Images.SetKeyName(8, "network")
        Me.imgProcessTab.Images.SetKeyName(9, "font")
        Me.imgProcessTab.Images.SetKeyName(10, "environment")
        Me.imgProcessTab.Images.SetKeyName(11, "dll")
        Me.imgProcessTab.Images.SetKeyName(12, "thread")
        Me.imgProcessTab.Images.SetKeyName(13, "handle")
        Me.imgProcessTab.Images.SetKeyName(14, "windows")
        '
        'timerProcPerf
        '
        Me.timerProcPerf.Enabled = True
        Me.timerProcPerf.Interval = 1000
        '
        'imgProcess
        '
        Me.imgProcess.ImageStream = CType(resources.GetObject("imgProcess.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgProcess.TransparentColor = System.Drawing.Color.Transparent
        Me.imgProcess.Images.SetKeyName(0, "noIcon")
        '
        'imgMain
        '
        Me.imgMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgMain.ImageSize = New System.Drawing.Size(16, 16)
        Me.imgMain.TransparentColor = System.Drawing.Color.Transparent
        '
        'timerLog
        '
        Me.timerLog.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "&main"
        Me.MainToolStripMenuItem.Visible = False
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'ViewDependenciesToolStripMenuItem
        '
        Me.ViewDependenciesToolStripMenuItem.Image = Global.YAPM.My.Resources.Resources.dllIcon
        Me.ViewDependenciesToolStripMenuItem.Name = "ViewDependenciesToolStripMenuItem"
        Me.ViewDependenciesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ViewDependenciesToolStripMenuItem.Text = "View dependencies"
        '
        'frmProcessInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 323)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tabProcess)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(660, 359)
        Me.Name = "frmProcessInfo"
        Me.Text = "Process informations"
        Me.tabProcess.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.SplitContainerOnlineInfo.Panel1.ResumeLayout(False)
        Me.SplitContainerOnlineInfo.Panel1.PerformLayout()
        Me.SplitContainerOnlineInfo.Panel2.ResumeLayout(False)
        Me.SplitContainerOnlineInfo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpProcGeneralFile.ResumeLayout(False)
        Me.gpProcGeneralFile.PerformLayout()
        CType(Me.pctSmallIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuCopyPctSmall.ResumeLayout(False)
        CType(Me.pctBigIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuCopyPctbig.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.splitPerformances.Panel1.ResumeLayout(False)
        Me.splitPerformances.Panel2.ResumeLayout(False)
        Me.splitPerformances.ResumeLayout(False)
        CType(Me.graphCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitPerformance2.Panel1.ResumeLayout(False)
        Me.splitPerformance2.Panel2.ResumeLayout(False)
        Me.splitPerformance2.ResumeLayout(False)
        CType(Me.graphMemory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graphIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.tabProcessToken.ResumeLayout(False)
        Me.tabProcessTokenPagePrivileges.ResumeLayout(False)
        Me.menuPrivileges.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.menuProcMem.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.SplitContainerInfoProcess.Panel1.ResumeLayout(False)
        Me.SplitContainerInfoProcess.Panel2.ResumeLayout(False)
        Me.SplitContainerInfoProcess.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.menuProcServ.ResumeLayout(False)
        Me.tabNetwork.ResumeLayout(False)
        Me.menuNetwork.ResumeLayout(False)
        Me.TabPageString.ResumeLayout(False)
        Me.SplitContainerStrings.Panel1.ResumeLayout(False)
        Me.SplitContainerStrings.Panel2.ResumeLayout(False)
        Me.SplitContainerStrings.Panel2.PerformLayout()
        Me.SplitContainerStrings.ResumeLayout(False)
        Me.menuString.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.menuModule.ResumeLayout(False)
        Me.TabPage11.ResumeLayout(False)
        Me.menuThread.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.menuWindow.ResumeLayout(False)
        Me.TabPage13.ResumeLayout(False)
        Me.menuHandles.ResumeLayout(False)
        Me.TabPage14.ResumeLayout(False)
        Me.SplitContainerLog.Panel1.ResumeLayout(False)
        Me.SplitContainerLog.Panel1.PerformLayout()
        Me.SplitContainerLog.Panel2.ResumeLayout(False)
        Me.SplitContainerLog.ResumeLayout(False)
        Me.TabPage15.ResumeLayout(False)
        Me.containerHistory.Panel1.ResumeLayout(False)
        Me.containerHistory.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabProcess As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProcessUser As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtProcessId As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents gpProcGeneralFile As System.Windows.Forms.GroupBox
    Friend WithEvents cmdShowFileDetails As System.Windows.Forms.Button
    Friend WithEvents cmdShowFileProperties As System.Windows.Forms.Button
    Friend WithEvents cmdOpenDirectory As System.Windows.Forms.Button
    Friend WithEvents txtProcessPath As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtImageVersion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents pctSmallIcon As System.Windows.Forms.PictureBox
    Friend WithEvents pctBigIcon As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUserObjectsCount As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents lblGDIcount As System.Windows.Forms.Label
    Friend WithEvents lbl789 As System.Windows.Forms.Label
    Friend WithEvents lblHandles As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblProcOtherBytes As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblProcOther As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblProcWriteBytes As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblProcWrites As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lblProcReadBytes As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblProcReads As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuotaNPP As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblQuotaPNPP As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblQuotaPP As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblQuotaPPP As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblPageFaults As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblPeakPageFileUsage As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lblPageFileUsage As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblPeakWorkingSet As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblWorkingSet As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalTime As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblUserTime As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblKernelTime As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents splitPerformances As System.Windows.Forms.SplitContainer
    Friend WithEvents graphCPU As YAPM.Graph2
    Friend WithEvents splitPerformance2 As System.Windows.Forms.SplitContainer
    Friend WithEvents graphMemory As YAPM.Graph2
    Friend WithEvents graphIO As YAPM.Graph2
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents tabProcessToken As System.Windows.Forms.TabControl
    Friend WithEvents tabProcessTokenPagePrivileges As System.Windows.Forms.TabPage
    Friend WithEvents lvPrivileges As Providers.privilegeList
    Friend WithEvents ColumnHeader50 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader51 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader52 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lvProcMem As Providers.memoryList
    Friend WithEvents ColumnHeader53 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader54 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader55 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader56 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainerInfoProcess As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdInfosToClipB As System.Windows.Forms.Button
    Friend WithEvents rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents tabNetwork As System.Windows.Forms.TabPage
    Friend WithEvents lvProcNetwork As Providers.networkList
    Friend WithEvents ColumnHeader49 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader57 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader58 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader59 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPageString As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainerStrings As System.Windows.Forms.SplitContainer
    Friend WithEvents lvProcString As YAPM.DoubleBufferedLV
    Friend WithEvents ColumnHeader76 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader77 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdProcSearchR As System.Windows.Forms.Button
    Friend WithEvents cmdProcSearchL As System.Windows.Forms.Button
    Friend WithEvents pgbString As System.Windows.Forms.ProgressBar
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtSearchProcString As System.Windows.Forms.TextBox
    Friend WithEvents cmdProcStringSave As System.Windows.Forms.Button
    Friend WithEvents optProcStringMemory As System.Windows.Forms.RadioButton
    Friend WithEvents optProcStringImage As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents lvProcEnv As Providers.envVariableList
    Friend WithEvents ColumnHeader60 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader61 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuCopyPctbig As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCopyPctSmall As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPrivileges As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem44 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuProcMem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem49 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JumpToPEBAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timerProcPerf As System.Windows.Forms.Timer
    Friend WithEvents imgProcess As System.Windows.Forms.ImageList
    Friend WithEvents imgProcessTab As System.Windows.Forms.ImageList
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerOnlineInfo As System.Windows.Forms.SplitContainer
    Friend WithEvents lblSecurityRisk As System.Windows.Forms.Label
    Friend WithEvents cmdGetOnlineInfos As System.Windows.Forms.Button
    Friend WithEvents rtbOnlineInfos As System.Windows.Forms.RichTextBox
    Friend WithEvents lvModules As Providers.moduleList
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader43 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader44 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader45 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader46 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuModule As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowFileDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem36 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem39 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GoogleSearchToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuThread As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem23 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem27 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LowestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem28 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem29 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem30 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem31 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem32 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem33 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvWindows As Providers.windowList
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader41 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader42 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuWindow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lvHandles As Providers.handleList
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuHandles As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewMemoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BringToFrontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoNotBringToFrontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAsActiveWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAsForegroundWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MinimizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PositionSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCommandLine As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAverageCPUusage As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents imgMain As System.Windows.Forms.ImageList
    Friend WithEvents ShowUnnamedHandlesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowUnnamedWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuString As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuViewMemoryString As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvProcServices As Providers.serviceList
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChooseColumnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChooseColumnsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChooseColumnsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChooseColumnsToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChooseColumnsToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNetwork As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage14 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainerLog As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLog As YAPM.DoubleBufferedLV
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkLog As System.Windows.Forms.CheckBox
    Friend WithEvents timerLog As System.Windows.Forms.Timer
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClearLog As System.Windows.Forms.Button
    Friend WithEvents cmdLogOptions As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage15 As System.Windows.Forms.TabPage
    Friend WithEvents lstHistoryCat As System.Windows.Forms.CheckedListBox
    Friend WithEvents containerHistory As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdKill As System.Windows.Forms.Button
    Friend WithEvents cmdSet As System.Windows.Forms.Button
    Friend WithEvents cbPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAffinity As System.Windows.Forms.Button
    Friend WithEvents cmdPause As System.Windows.Forms.Button
    Friend WithEvents cmdResume As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvThreads As Providers.threadList
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuProcServ As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem43 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PauseToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutdownShutdownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeOfStartToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisabledToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DemandToolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReanalyzeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FilePropToolStripMenuItem34 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDirToolStripMenuItem35 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GoogleSearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem37 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChooseColumnsToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblOthersBD As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOtherD As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblWBD As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblWD As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblRBD As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents lblRD As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lblThreads As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPriority As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRunTime As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessStarted As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtParentProcess As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdInspectExe As System.Windows.Forms.Button
    Friend WithEvents ViewDependenciesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
