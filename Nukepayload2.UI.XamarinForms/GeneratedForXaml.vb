Option Strict On
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.ChatViewTemples.xaml", "Themes\ChatViewTemples.xaml", GetType(Global.Nukepayload2.UI.Xaml.ChatViewTemples))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.DefaultContentTemplates.xaml", "Themes\DefaultContentTemplates.xaml", GetType(Global.Nukepayload2.UI.Xaml.DefaultContentTemplates))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.TimelineTemplates.xaml", "Themes\TimelineTemplates.xaml", GetType(Global.Nukepayload2.UI.Xaml.TimelineTemplates))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.ChatView.xaml", "Views\ChatView.xaml", GetType(Global.Nukepayload2.UI.Xaml.ChatView))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.CheckBox.xaml", "Views\CheckBox.xaml", GetType(Global.Nukepayload2.UI.Xaml.CheckBox))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.ComboBox.xaml", "Views\ComboBox.xaml", GetType(Global.Nukepayload2.UI.Xaml.ComboBox))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.EditorControl.xaml", "Views\EditorControl.xaml", GetType(Global.Nukepayload2.UI.Xaml.EditorControl))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.EmbeddedWebViewPage.xaml", "Views\EmbeddedWebViewPage.xaml", GetType(Global.Nukepayload2.UI.Xaml.Views.EmbeddedWebViewPage))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.Expander.xaml", "Views\Expander.xaml", GetType(Global.Nukepayload2.UI.Xaml.Expander))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.Flyout.xaml", "Views\Flyout.xaml", GetType(Global.Nukepayload2.UI.Xaml.Flyout))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.FlyoutContainer.xaml", "Views\FlyoutContainer.xaml", GetType(Global.Nukepayload2.UI.Xaml.FlyoutContainer))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.HyperlinkButton.xaml", "Views\HyperlinkButton.xaml", GetType(Global.Nukepayload2.UI.Xaml.HyperlinkButton))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.TimelineEditor.xaml", "Views\TimelineEditor.xaml", GetType(Global.Nukepayload2.UI.Xaml.TimelineEditor))>
<Assembly: Global.Xamarin.Forms.Xaml.XamlResourceId("Nukepayload2.UI.Xaml.TimelineView.xaml", "Views\TimelineView.xaml", GetType(Global.Nukepayload2.UI.Xaml.TimelineView))>


Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Themes\ChatViewTemples.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(ChatViewTemples))

    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Themes\DefaultContentTemplates.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(DefaultContentTemplates))

    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Themes\TimelineTemplates.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(TimelineTemplates))

    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\ChatView.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(ChatView))

    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\CheckBox.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(CheckBox))
CheckBoxInteractiveArea = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(Me, NameOf(CheckBoxInteractiveArea))
CtlBlackRectangle = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.BoxView)(Me, NameOf(CtlBlackRectangle))
CtlWhiteRectangle = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.BoxView)(Me, NameOf(CtlWhiteRectangle))
CtlBlueRectangle = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.BoxView)(Me, NameOf(CtlBlueRectangle))
LblChecked = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Label)(Me, NameOf(LblChecked))
CtlContent = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Nukepayload2.UI.Xaml.ContentControl)(Me, NameOf(CtlContent))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\ComboBox.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(ComboBox))
FlyItemPicker = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Nukepayload2.UI.Xaml.Flyout)(Me, NameOf(FlyItemPicker))
ScrFlyout = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.ScrollView)(Me, NameOf(ScrFlyout))
LstFlyout = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Nukepayload2.UI.Xaml.ItemsControl)(Me, NameOf(LstFlyout))
CtlButtonPart = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(Me, NameOf(CtlButtonPart))
ItmContent = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Nukepayload2.UI.Xaml.ContentControl)(Me, NameOf(ItmContent))
LblArrow = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Label)(Me, NameOf(LblArrow))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\EditorControl.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(EditorControl))
ViewPart = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Nukepayload2.UI.Xaml.ContentControl)(Me, NameOf(ViewPart))
EditPart = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Nukepayload2.UI.Xaml.ContentControl)(Me, NameOf(EditPart))
EditToggleButton = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(EditToggleButton))
SaveToggleButton = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(SaveToggleButton))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\EmbeddedWebViewPage.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(EmbeddedWebViewPage))
WebBrowser = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.WebView)(Me, NameOf(WebBrowser))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\Expander.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(Expander))
GrdBackground = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Grid)(Me, NameOf(GrdBackground))
HeaderHitTest = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(Me, NameOf(HeaderHitTest))
Arrow = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Label)(Me, NameOf(Arrow))
LblHeader = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Label)(Me, NameOf(LblHeader))
CtlContent = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.ContentView)(Me, NameOf(CtlContent))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\Flyout.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(Flyout))
CtlInner = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.ContentView)(Me, NameOf(CtlInner))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\FlyoutContainer.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(FlyoutContainer))
GrdRoot = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Grid)(Me, NameOf(GrdRoot))
BackgroundInput = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(Me, NameOf(BackgroundInput))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\HyperlinkButton.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(HyperlinkButton))
TblLink = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.TapGestureRecognizer)(Me, NameOf(TblLink))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\TimelineEditor.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(TimelineEditor))
LblHeader = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Label)(Me, NameOf(LblHeader))
BtnAddDate = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(BtnAddDate))
BtnAddTime = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(BtnAddTime))
BtnAddAction = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(BtnAddAction))
BtnDelete = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(BtnDelete))
BtnUndo = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(BtnUndo))
BtnRedo = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(BtnRedo))
BtnMoveUp = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(BtnMoveUp))
BtnMoveDown = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Xamarin.Forms.Button)(Me, NameOf(BtnMoveDown))
LstItems = Global.Xamarin.Forms.NameScopeExtensions.FindByName(Of Global.Nukepayload2.UI.Xaml.ListBox)(Me, NameOf(LstItems))
    End Sub
End Class
End Namespace
Namespace Global.Nukepayload2.UI.Xaml
<Global.Xamarin.Forms.Xaml.XamlFilePath("Views\TimelineView.xaml")>
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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(TimelineView))

    End Sub
End Class
End Namespace

