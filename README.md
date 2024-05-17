# How to apply padding for Column Elements in MAUI DataGrid?

By default the [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) has padding values applied to each cell.
#### XAML
We can update the padding of each cell using [CellPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellPadding) and [HeaderPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderPadding). `CellPadding` targets the `DataGridCell`, while `HeaderPadding` targets the `DataGridHeaderCell`.
```XML
<syncfusion:SfDataGrid x:Name="dataGrid"
                    x:DataType="local:EmployeeViewModel"
                    RowHeight="30"
                    ColumnWidthMode="Auto"
                    ItemsSource="{Binding Employees}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn MappingName="EmployeeID" HeaderText="Employee ID" Format="D" CellPadding="0" HeaderPadding="0"/>
        <syncfusion:DataGridTextColumn MappingName="Name" CellPadding="16, 0 ,16, 0" HeaderPadding="16 ,0, 16, 0" />
        <syncfusion:DataGridTextColumn MappingName="Title" CellPadding="16, 0, 16, 0" HeaderPadding="16, 0, 16, 0"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
```

#### C#
Similar code as XAML
```C#
public MainPage()
{
    InitializeComponent();
    DataGridNumericColumn EmployeeIDColumn = new DataGridNumericColumn() { MappingName = "EmployeeID" , HeaderText = "Employee ID" , Format= "D" , CellPadding  = new Thickness(16,0,16,0), HeaderPadding = new Thickness(16,0,16,0) };
    DataGridTextColumn NameColumn = new DataGridTextColumn() { MappingName = "Name", HeaderText = "Name",  CellPadding = new Thickness(16, 0, 16, 0), HeaderPadding = new Thickness(16, 0, 16, 0) };
    DataGridTextColumn Title = new DataGridTextColumn() { MappingName = "Title", HeaderText = "Title", CellPadding = new Thickness(16, 0, 16, 0), HeaderPadding = new Thickness(16, 0, 16, 0) };
    dataGrid.Columns.Add(EmployeeIDColumn);
    dataGrid.Columns.Add(NameColumn);
    dataGrid.Columns.Add(Title);
}
```

![DataGrid padding](SfDataGrid_ColumnPadding.png)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-apply-padding-for-Column-Elements-in-MAUI-DataGrid)

Take a moment to pursue this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples.
Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid(SfDataGrid).

### Conclusion
I hope you enjoyed learning about how to apply padding for Column Elements in MAUI DataGrid?

You can refer to our [.NET MAUI DataGrid's feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to know about its other groundbreaking feature representations. You can also explore our .NET MAUI DataGrid Documentation to understand how to present and manipulate data.
For current customers, you can check out our .NET MAUI components from the [License and Downloads](https://www.syncfusion.com/account/downloads) page. If you are new to Syncfusion, you can try our 30-day free trial to check out our .NET MAUI DataGrid and other .NET MAUI components.
If you have any queries or require clarifications, please let us know in comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/account/login?ReturnUrl=%2Faccount%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dc54e52f3eb3cde0c3f20474f1bc179ed%26redirect_uri%3Dhttps%253A%252F%252Fsupport.syncfusion.com%252Fagent%252Flogincallback%26response_type%3Dcode%26scope%3Dopenid%2520profile%2520agent.api%2520integration.api%2520offline_access%2520kb.api%26state%3D8db41f98953a4d9ba40407b150ad4cf2%26code_challenge%3DvwHoT64z2h21eP_A9g7JWtr3vp3iPrvSjfh5hN5C7IE%26code_challenge_method%3DS256%26response_mode%3Dquery) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid). We are always happy to assist you!