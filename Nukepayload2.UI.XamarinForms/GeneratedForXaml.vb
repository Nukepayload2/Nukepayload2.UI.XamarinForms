Option Strict On
Imports System.ComponentModel
Imports Xamarin.Forms
Imports Xamarin.Forms.Xaml


Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Themes\ChatViewTemples.xaml")>
Partial Public Class ChatViewTemples
    Inherits Global.Xamarin.Forms.ResourceDictionary


    Private _SegoeMdl2AssetsConverter As Global.Nukepayload2.UI.Xaml.SegoeMdl2AssetsConverter
    Public ReadOnly Property SegoeMdl2AssetsConverter As Global.Nukepayload2.UI.Xaml.SegoeMdl2AssetsConverter
        Get
            If _SegoeMdl2AssetsConverter Is Nothing Then
                _SegoeMdl2AssetsConverter = DirectCast(Me!SegoeMdl2AssetsConverter, Global.Nukepayload2.UI.Xaml.SegoeMdl2AssetsConverter)
            End If
            Return _SegoeMdl2AssetsConverter
        End Get
    End Property

    Private _DateTimeStringConverter As Global.Nukepayload2.UI.Xaml.DateTimeStringConverter
    Public ReadOnly Property DateTimeStringConverter As Global.Nukepayload2.UI.Xaml.DateTimeStringConverter
        Get
            If _DateTimeStringConverter Is Nothing Then
                _DateTimeStringConverter = DirectCast(Me!DateTimeStringConverter, Global.Nukepayload2.UI.Xaml.DateTimeStringConverter)
            End If
            Return _DateTimeStringConverter
        End Get
    End Property

    Private _ChatItemDataTemplateSelector As Global.Nukepayload2.UI.Xaml.ChatItemDataTemplateSelector
    Public ReadOnly Property ChatItemDataTemplateSelector As Global.Nukepayload2.UI.Xaml.ChatItemDataTemplateSelector
        Get
            If _ChatItemDataTemplateSelector Is Nothing Then
                _ChatItemDataTemplateSelector = DirectCast(Me!ChatItemDataTemplateSelector, Global.Nukepayload2.UI.Xaml.ChatItemDataTemplateSelector)
            End If
            Return _ChatItemDataTemplateSelector
        End Get
    End Property

    Private _ChatItemContentTemplateSelector As Global.Nukepayload2.UI.Xaml.ChatItemContentTemplateSelector
    Public ReadOnly Property ChatItemContentTemplateSelector As Global.Nukepayload2.UI.Xaml.ChatItemContentTemplateSelector
        Get
            If _ChatItemContentTemplateSelector Is Nothing Then
                _ChatItemContentTemplateSelector = DirectCast(Me!ChatItemContentTemplateSelector, Global.Nukepayload2.UI.Xaml.ChatItemContentTemplateSelector)
            End If
            Return _ChatItemContentTemplateSelector
        End Get
    End Property

    Private _ImageLoader As Global.Nukepayload2.UI.Xaml.ImageLoader
    Public ReadOnly Property ImageLoader As Global.Nukepayload2.UI.Xaml.ImageLoader
        Get
            If _ImageLoader Is Nothing Then
                _ImageLoader = DirectCast(Me!ImageLoader, Global.Nukepayload2.UI.Xaml.ImageLoader)
            End If
            Return _ImageLoader
        End Get
    End Property

    Private _CheckColorConverter As Global.Nukepayload2.UI.Xaml.CheckColorConverter
    Public ReadOnly Property CheckColorConverter As Global.Nukepayload2.UI.Xaml.CheckColorConverter
        Get
            If _CheckColorConverter Is Nothing Then
                _CheckColorConverter = DirectCast(Me!CheckColorConverter, Global.Nukepayload2.UI.Xaml.CheckColorConverter)
            End If
            Return _CheckColorConverter
        End Get
    End Property

    Private _CheckTextConverter As Global.Nukepayload2.UI.Xaml.CheckTextConverter
    Public ReadOnly Property CheckTextConverter As Global.Nukepayload2.UI.Xaml.CheckTextConverter
        Get
            If _CheckTextConverter Is Nothing Then
                _CheckTextConverter = DirectCast(Me!CheckTextConverter, Global.Nukepayload2.UI.Xaml.CheckTextConverter)
            End If
            Return _CheckTextConverter
        End Get
    End Property

    Private _HtmlContentMessageTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property HtmlContentMessageTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _HtmlContentMessageTemplate Is Nothing Then
                _HtmlContentMessageTemplate = DirectCast(Me!HtmlContentMessageTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _HtmlContentMessageTemplate
        End Get
    End Property

    Private _HyperlinkMessageTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property HyperlinkMessageTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _HyperlinkMessageTemplate Is Nothing Then
                _HyperlinkMessageTemplate = DirectCast(Me!HyperlinkMessageTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _HyperlinkMessageTemplate
        End Get
    End Property

    Private _ImageMessageTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property ImageMessageTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _ImageMessageTemplate Is Nothing Then
                _ImageMessageTemplate = DirectCast(Me!ImageMessageTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _ImageMessageTemplate
        End Get
    End Property

    Private _TextMessageTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TextMessageTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TextMessageTemplate Is Nothing Then
                _TextMessageTemplate = DirectCast(Me!TextMessageTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TextMessageTemplate
        End Get
    End Property

    Private _InviteMessageTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property InviteMessageTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _InviteMessageTemplate Is Nothing Then
                _InviteMessageTemplate = DirectCast(Me!InviteMessageTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _InviteMessageTemplate
        End Get
    End Property

    Private _MessageGroupByDateDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property MessageGroupByDateDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _MessageGroupByDateDataTemplate Is Nothing Then
                _MessageGroupByDateDataTemplate = DirectCast(Me!MessageGroupByDateDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _MessageGroupByDateDataTemplate
        End Get
    End Property

    Private _ChatButtonDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property ChatButtonDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _ChatButtonDataTemplate Is Nothing Then
                _ChatButtonDataTemplate = DirectCast(Me!ChatButtonDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _ChatButtonDataTemplate
        End Get
    End Property

    Private _ListViewChatItemLeftDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property ListViewChatItemLeftDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _ListViewChatItemLeftDataTemplate Is Nothing Then
                _ListViewChatItemLeftDataTemplate = DirectCast(Me!ListViewChatItemLeftDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _ListViewChatItemLeftDataTemplate
        End Get
    End Property

    Private _ListViewChatItemRightDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property ListViewChatItemRightDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _ListViewChatItemRightDataTemplate Is Nothing Then
                _ListViewChatItemRightDataTemplate = DirectCast(Me!ListViewChatItemRightDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _ListViewChatItemRightDataTemplate
        End Get
    End Property
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(ChatViewTemples))

    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Themes\DefaultContentTemplates.xaml")>
Partial Public Class DefaultContentTemplates
    Inherits Global.Xamarin.Forms.ResourceDictionary


    Private _CheckBoxDefaultContentTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property CheckBoxDefaultContentTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _CheckBoxDefaultContentTemplate Is Nothing Then
                _CheckBoxDefaultContentTemplate = DirectCast(Me!CheckBoxDefaultContentTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _CheckBoxDefaultContentTemplate
        End Get
    End Property
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(DefaultContentTemplates))

    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Themes\TimelineTemplates.xaml")>
Partial Public Class TimelineTemplates
    Inherits Global.Xamarin.Forms.ResourceDictionary


    Private _TimelineIconImageConverter As Global.Nukepayload2.UI.Xaml.TimelineIconImageConverter
    Public ReadOnly Property TimelineIconImageConverter As Global.Nukepayload2.UI.Xaml.TimelineIconImageConverter
        Get
            If _TimelineIconImageConverter Is Nothing Then
                _TimelineIconImageConverter = DirectCast(Me!TimelineIconImageConverter, Global.Nukepayload2.UI.Xaml.TimelineIconImageConverter)
            End If
            Return _TimelineIconImageConverter
        End Get
    End Property

    Private _TimelineIconTextConverter As Global.Nukepayload2.UI.Xaml.TimelineIconTextConverter
    Public ReadOnly Property TimelineIconTextConverter As Global.Nukepayload2.UI.Xaml.TimelineIconTextConverter
        Get
            If _TimelineIconTextConverter Is Nothing Then
                _TimelineIconTextConverter = DirectCast(Me!TimelineIconTextConverter, Global.Nukepayload2.UI.Xaml.TimelineIconTextConverter)
            End If
            Return _TimelineIconTextConverter
        End Get
    End Property

    Private _EnumItemsConverter As Global.Nukepayload2.UI.Xaml.EnumItemsConverter
    Public ReadOnly Property EnumItemsConverter As Global.Nukepayload2.UI.Xaml.EnumItemsConverter
        Get
            If _EnumItemsConverter Is Nothing Then
                _EnumItemsConverter = DirectCast(Me!EnumItemsConverter, Global.Nukepayload2.UI.Xaml.EnumItemsConverter)
            End If
            Return _EnumItemsConverter
        End Get
    End Property

    Private _TimelineActionViewDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineActionViewDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineActionViewDataTemplate Is Nothing Then
                _TimelineActionViewDataTemplate = DirectCast(Me!TimelineActionViewDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineActionViewDataTemplate
        End Get
    End Property

    Private _TimelineActionIconViewDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineActionIconViewDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineActionIconViewDataTemplate Is Nothing Then
                _TimelineActionIconViewDataTemplate = DirectCast(Me!TimelineActionIconViewDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineActionIconViewDataTemplate
        End Get
    End Property

    Private _TimelineDateViewDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineDateViewDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineDateViewDataTemplate Is Nothing Then
                _TimelineDateViewDataTemplate = DirectCast(Me!TimelineDateViewDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineDateViewDataTemplate
        End Get
    End Property

    Private _TimelineTimeViewDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineTimeViewDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineTimeViewDataTemplate Is Nothing Then
                _TimelineTimeViewDataTemplate = DirectCast(Me!TimelineTimeViewDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineTimeViewDataTemplate
        End Get
    End Property

    Private _TimelineActionEditorDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineActionEditorDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineActionEditorDataTemplate Is Nothing Then
                _TimelineActionEditorDataTemplate = DirectCast(Me!TimelineActionEditorDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineActionEditorDataTemplate
        End Get
    End Property

    Private _TimelineActionEditDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineActionEditDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineActionEditDataTemplate Is Nothing Then
                _TimelineActionEditDataTemplate = DirectCast(Me!TimelineActionEditDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineActionEditDataTemplate
        End Get
    End Property

    Private _TimelineDateEditorDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineDateEditorDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineDateEditorDataTemplate Is Nothing Then
                _TimelineDateEditorDataTemplate = DirectCast(Me!TimelineDateEditorDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineDateEditorDataTemplate
        End Get
    End Property

    Private _TimelineDateEditDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineDateEditDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineDateEditDataTemplate Is Nothing Then
                _TimelineDateEditDataTemplate = DirectCast(Me!TimelineDateEditDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineDateEditDataTemplate
        End Get
    End Property

    Private _TimelineTimeEditorDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineTimeEditorDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineTimeEditorDataTemplate Is Nothing Then
                _TimelineTimeEditorDataTemplate = DirectCast(Me!TimelineTimeEditorDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineTimeEditorDataTemplate
        End Get
    End Property

    Private _TimelineTimeEditDataTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TimelineTimeEditDataTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TimelineTimeEditDataTemplate Is Nothing Then
                _TimelineTimeEditDataTemplate = DirectCast(Me!TimelineTimeEditDataTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TimelineTimeEditDataTemplate
        End Get
    End Property
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(TimelineTemplates))

    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\ChatView.xaml")>
Partial Public Class ChatView
    Inherits Global.Xamarin.Forms.ContentView


    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(ChatView))

    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\CheckBox.xaml")>
Partial Public Class CheckBox
    Inherits Global.Xamarin.Forms.ContentView
Private  CheckBoxInteractiveArea As Global.Xamarin.Forms.TapGestureRecognizer
Private  CtlBlackRectangle As Global.Xamarin.Forms.BoxView
Private  CtlWhiteRectangle As Global.Xamarin.Forms.BoxView
Private  CtlBlueRectangle As Global.Xamarin.Forms.BoxView
Private  LblChecked As Global.Xamarin.Forms.Label
Private  CtlContent As Global.Nukepayload2.UI.Xaml.ContentControl
Private WithEvents CheckBoxInteractiveAreaWithEvents As Global.Xamarin.Forms.TapGestureRecognizer
Private WithEvents CtlBlackRectangleWithEvents As Global.Xamarin.Forms.BoxView
Private WithEvents CtlWhiteRectangleWithEvents As Global.Xamarin.Forms.BoxView
Private WithEvents CtlBlueRectangleWithEvents As Global.Xamarin.Forms.BoxView
Private WithEvents LblCheckedWithEvents As Global.Xamarin.Forms.Label
Private WithEvents CtlContentWithEvents As Global.Nukepayload2.UI.Xaml.ContentControl
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
CheckBoxInteractiveAreaWithEvents = CheckBoxInteractiveArea
CtlBlackRectangleWithEvents = CtlBlackRectangle
CtlWhiteRectangleWithEvents = CtlWhiteRectangle
CtlBlueRectangleWithEvents = CtlBlueRectangle
LblCheckedWithEvents = LblChecked
CtlContentWithEvents = CtlContent
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(CheckBox))
CheckBoxInteractiveArea = Content.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(NameOf(CheckBoxInteractiveArea))
CtlBlackRectangle = Content.FindByName(Of Global.Xamarin.Forms.BoxView)(NameOf(CtlBlackRectangle))
CtlWhiteRectangle = Content.FindByName(Of Global.Xamarin.Forms.BoxView)(NameOf(CtlWhiteRectangle))
CtlBlueRectangle = Content.FindByName(Of Global.Xamarin.Forms.BoxView)(NameOf(CtlBlueRectangle))
LblChecked = Content.FindByName(Of Global.Xamarin.Forms.Label)(NameOf(LblChecked))
CtlContent = Content.FindByName(Of Global.Nukepayload2.UI.Xaml.ContentControl)(NameOf(CtlContent))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\ComboBox.xaml")>
Partial Public Class ComboBox
    Inherits Global.Nukepayload2.UI.Xaml.Primitives.Selector
Private  FlyItemPicker As Global.Nukepayload2.UI.Xaml.Flyout
Private  ScrFlyout As Global.Xamarin.Forms.ScrollView
Private  LstFlyout As Global.Nukepayload2.UI.Xaml.ItemsControl
Private  CtlButtonPart As Global.Xamarin.Forms.TapGestureRecognizer
Private  ItmContent As Global.Nukepayload2.UI.Xaml.ContentControl
Private  LblArrow As Global.Xamarin.Forms.Label
Private WithEvents FlyItemPickerWithEvents As Global.Nukepayload2.UI.Xaml.Flyout
Private WithEvents ScrFlyoutWithEvents As Global.Xamarin.Forms.ScrollView
Private WithEvents LstFlyoutWithEvents As Global.Nukepayload2.UI.Xaml.ItemsControl
Private WithEvents CtlButtonPartWithEvents As Global.Xamarin.Forms.TapGestureRecognizer
Private WithEvents ItmContentWithEvents As Global.Nukepayload2.UI.Xaml.ContentControl
Private WithEvents LblArrowWithEvents As Global.Xamarin.Forms.Label
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
FlyItemPickerWithEvents = FlyItemPicker
ScrFlyoutWithEvents = ScrFlyout
LstFlyoutWithEvents = LstFlyout
CtlButtonPartWithEvents = CtlButtonPart
ItmContentWithEvents = ItmContent
LblArrowWithEvents = LblArrow
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(ComboBox))
FlyItemPicker = Content.FindByName(Of Global.Nukepayload2.UI.Xaml.Flyout)(NameOf(FlyItemPicker))
ScrFlyout = Content.FindByName(Of Global.Xamarin.Forms.ScrollView)(NameOf(ScrFlyout))
LstFlyout = Content.FindByName(Of Global.Nukepayload2.UI.Xaml.ItemsControl)(NameOf(LstFlyout))
CtlButtonPart = Content.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(NameOf(CtlButtonPart))
ItmContent = Content.FindByName(Of Global.Nukepayload2.UI.Xaml.ContentControl)(NameOf(ItmContent))
LblArrow = Content.FindByName(Of Global.Xamarin.Forms.Label)(NameOf(LblArrow))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\EditorControl.xaml")>
Partial Public Class EditorControl
    Inherits Global.Xamarin.Forms.ContentView
Protected  ViewPart As Global.Nukepayload2.UI.Xaml.ContentControl
Protected  EditPart As Global.Nukepayload2.UI.Xaml.ContentControl
Private  EditToggleButton As Global.Xamarin.Forms.Button
Private  SaveToggleButton As Global.Xamarin.Forms.Button
Protected WithEvents ViewPartWithEvents As Global.Nukepayload2.UI.Xaml.ContentControl
Protected WithEvents EditPartWithEvents As Global.Nukepayload2.UI.Xaml.ContentControl
Private WithEvents EditToggleButtonWithEvents As Global.Xamarin.Forms.Button
Private WithEvents SaveToggleButtonWithEvents As Global.Xamarin.Forms.Button
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
ViewPartWithEvents = ViewPart
EditPartWithEvents = EditPart
EditToggleButtonWithEvents = EditToggleButton
SaveToggleButtonWithEvents = SaveToggleButton
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(EditorControl))
ViewPart = Content.FindByName(Of Global.Nukepayload2.UI.Xaml.ContentControl)(NameOf(ViewPart))
EditPart = Content.FindByName(Of Global.Nukepayload2.UI.Xaml.ContentControl)(NameOf(EditPart))
EditToggleButton = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(EditToggleButton))
SaveToggleButton = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(SaveToggleButton))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\EmbeddedWebViewPage.xaml")>
Partial Public Class EmbeddedWebViewPage
    Inherits Global.Xamarin.Forms.ContentPage
Private  WebBrowser As Global.Xamarin.Forms.WebView
Private WithEvents WebBrowserWithEvents As Global.Xamarin.Forms.WebView
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
WebBrowserWithEvents = WebBrowser
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(EmbeddedWebViewPage))
WebBrowser = Content.FindByName(Of Global.Xamarin.Forms.WebView)(NameOf(WebBrowser))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\Expander.xaml")>
Partial Public Class Expander
    Inherits Global.Xamarin.Forms.ContentView
Private  GrdBackground As Global.Xamarin.Forms.Grid
Private  HeaderHitTest As Global.Xamarin.Forms.TapGestureRecognizer
Private  Arrow As Global.Xamarin.Forms.Label
Private  LblHeader As Global.Xamarin.Forms.Label
Private  CtlContent As Global.Xamarin.Forms.ContentView
Private WithEvents GrdBackgroundWithEvents As Global.Xamarin.Forms.Grid
Private WithEvents HeaderHitTestWithEvents As Global.Xamarin.Forms.TapGestureRecognizer
Private WithEvents ArrowWithEvents As Global.Xamarin.Forms.Label
Private WithEvents LblHeaderWithEvents As Global.Xamarin.Forms.Label
Private WithEvents CtlContentWithEvents As Global.Xamarin.Forms.ContentView
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
GrdBackgroundWithEvents = GrdBackground
HeaderHitTestWithEvents = HeaderHitTest
ArrowWithEvents = Arrow
LblHeaderWithEvents = LblHeader
CtlContentWithEvents = CtlContent
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(Expander))
GrdBackground = Content.FindByName(Of Global.Xamarin.Forms.Grid)(NameOf(GrdBackground))
HeaderHitTest = Content.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(NameOf(HeaderHitTest))
Arrow = Content.FindByName(Of Global.Xamarin.Forms.Label)(NameOf(Arrow))
LblHeader = Content.FindByName(Of Global.Xamarin.Forms.Label)(NameOf(LblHeader))
CtlContent = Content.FindByName(Of Global.Xamarin.Forms.ContentView)(NameOf(CtlContent))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\Flyout.xaml")>
Partial Public Class Flyout
    Inherits Global.Nukepayload2.UI.Xaml.FlyoutBase
Private  CtlInner As Global.Xamarin.Forms.ContentView
Private WithEvents CtlInnerWithEvents As Global.Xamarin.Forms.ContentView
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
CtlInnerWithEvents = CtlInner
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(Flyout))
CtlInner = Content.FindByName(Of Global.Xamarin.Forms.ContentView)(NameOf(CtlInner))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\FlyoutContainer.xaml")>
Partial Public Class FlyoutContainer
    Inherits Global.Xamarin.Forms.ContentView
Private  GrdRoot As Global.Xamarin.Forms.Grid
Private  BackgroundInput As Global.Xamarin.Forms.TapGestureRecognizer
Private WithEvents GrdRootWithEvents As Global.Xamarin.Forms.Grid
Private WithEvents BackgroundInputWithEvents As Global.Xamarin.Forms.TapGestureRecognizer
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
GrdRootWithEvents = GrdRoot
BackgroundInputWithEvents = BackgroundInput
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(FlyoutContainer))
GrdRoot = Content.FindByName(Of Global.Xamarin.Forms.Grid)(NameOf(GrdRoot))
BackgroundInput = Content.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(NameOf(BackgroundInput))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\HyperlinkButton.xaml")>
Partial Public Class HyperlinkButton
    Inherits Global.Xamarin.Forms.ContentView
Private  TblLink As Global.Xamarin.Forms.TapGestureRecognizer
Private WithEvents TblLinkWithEvents As Global.Xamarin.Forms.TapGestureRecognizer
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
TblLinkWithEvents = TblLink
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(HyperlinkButton))
TblLink = Content.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(NameOf(TblLink))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\TimelineEditor.xaml")>
Partial Public Class TimelineEditor
    Inherits Global.Xamarin.Forms.ContentView
Private  LblHeader As Global.Xamarin.Forms.Label
Private  BtnAddDate As Global.Xamarin.Forms.Button
Private  BtnAddTime As Global.Xamarin.Forms.Button
Private  BtnAddAction As Global.Xamarin.Forms.Button
Private  BtnDelete As Global.Xamarin.Forms.Button
Private  BtnUndo As Global.Xamarin.Forms.Button
Private  BtnRedo As Global.Xamarin.Forms.Button
Private  BtnMoveUp As Global.Xamarin.Forms.Button
Private  BtnMoveDown As Global.Xamarin.Forms.Button
Private  LstItems As Global.Nukepayload2.UI.Xaml.ListBox
Private WithEvents LblHeaderWithEvents As Global.Xamarin.Forms.Label
Private WithEvents BtnAddDateWithEvents As Global.Xamarin.Forms.Button
Private WithEvents BtnAddTimeWithEvents As Global.Xamarin.Forms.Button
Private WithEvents BtnAddActionWithEvents As Global.Xamarin.Forms.Button
Private WithEvents BtnDeleteWithEvents As Global.Xamarin.Forms.Button
Private WithEvents BtnUndoWithEvents As Global.Xamarin.Forms.Button
Private WithEvents BtnRedoWithEvents As Global.Xamarin.Forms.Button
Private WithEvents BtnMoveUpWithEvents As Global.Xamarin.Forms.Button
Private WithEvents BtnMoveDownWithEvents As Global.Xamarin.Forms.Button
Private WithEvents LstItemsWithEvents As Global.Nukepayload2.UI.Xaml.ListBox
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
LblHeaderWithEvents = LblHeader
BtnAddDateWithEvents = BtnAddDate
BtnAddTimeWithEvents = BtnAddTime
BtnAddActionWithEvents = BtnAddAction
BtnDeleteWithEvents = BtnDelete
BtnUndoWithEvents = BtnUndo
BtnRedoWithEvents = BtnRedo
BtnMoveUpWithEvents = BtnMoveUp
BtnMoveDownWithEvents = BtnMoveDown
LstItemsWithEvents = LstItems
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(TimelineEditor))
LblHeader = Content.FindByName(Of Global.Xamarin.Forms.Label)(NameOf(LblHeader))
BtnAddDate = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(BtnAddDate))
BtnAddTime = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(BtnAddTime))
BtnAddAction = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(BtnAddAction))
BtnDelete = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(BtnDelete))
BtnUndo = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(BtnUndo))
BtnRedo = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(BtnRedo))
BtnMoveUp = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(BtnMoveUp))
BtnMoveDown = Content.FindByName(Of Global.Xamarin.Forms.Button)(NameOf(BtnMoveDown))
LstItems = Content.FindByName(Of Global.Nukepayload2.UI.Xaml.ListBox)(NameOf(LstItems))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\Nukepayload2.UI.XamarinForms\Nukepayload2.UI.XamarinForms\Views\TimelineView.xaml")>
Partial Public Class TimelineView
    Inherits Global.Xamarin.Forms.ContentView


    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(TimelineView))

    End Sub
End Class
End Namespace

