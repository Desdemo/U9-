﻿


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;
using UFIDA.UBF.Query.CommonService;
using UFIDA.U9.UI.PDHelper;


/***********************************************************************************************
 * Form ID:a441ba8f-36d6-45ae-9569-eb1837e373ff 
 * Form Name:DynamicPriceBListUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.FeeRecordUI
{
	[FormRegister("UFIDA.U9.Cust.BLT.FeeRecordUI","UFIDA.U9.Cust.BLT.FeeRecordUI.DynamicPriceBListUIFormWebPart", "UFIDA.U9.Cust.BLT.FeeRecordUI.WebPart", "a441ba8f-36d6-45ae-9569-eb1837e373ff","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.BLT.FeeRecordUI', 'UFIDA.U9.Cust.BLT.FeeRecordUI.DynamicPriceBListUIFormWebPart', 'UFIDA.U9.Cust.BLT.FeeRecordUI.WebPart', 'a441ba8f-36d6-45ae-9569-eb1837e373ff')
	///<siteMapNode url="~/erp/simple.aspx?lnk=a441ba8f-36d6-45ae-9569-eb1837e373ff" title="DynamicPriceBListUIForm"/>
    public partial class DynamicPriceBListUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(DynamicPriceBListUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new DynamicPriceBListUIModelAction Action
		{
			get { return (DynamicPriceBListUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		DynamicPriceBListUIModelModel _uimodel=null;
		public new DynamicPriceBListUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new DynamicPriceBListUIModelModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as DynamicPriceBListUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar1;
        IUFButton BtnNew;
        IUFButton BtnDelete;
        IUFSeparator Separator0;
        IUFButton BtnOutPut;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFLabel Label0;
        IUFFldDropDownList DDLCase;
        IUFButton OnLookCase;
        IUFCard Card3;
        IUFDataGrid DataGrid1;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public DynamicPriceBListUIFormWebPart()
        {
            FormID = "a441ba8f-36d6-45ae-9569-eb1837e373ff";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnNew.Click += new EventHandler(BtnNew_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnOutPut.Click += new EventHandler(BtnOutPut_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
							
				//Button控件事件
			this.OnLookCase.Click += new EventHandler(OnLookCase_Click);		
						
				//Grid控件事件
			
			((UFWebDataGridAdapter)this.DataGrid1).RowDoubleClick += new GridRowDBClickedDelegate(DataGrid1_GridRowDbClicked);
			//((UFWebDataGridAdapter)this.DataGrid1).DBClickAutoPostBack = true;
						


            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new DynamicPriceBListUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (DynamicPriceBListUIModelModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new DynamicPriceBListUIModelAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"DynamicPriceBListUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar1, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar1(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar1",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar1 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnNew = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNew", "True", "True", 35, 28,"1", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","c9ad1524-4e1a-40d6-9d68-8e4cd52bbb7b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNew);
            this.BtnNew.UIModel = this.Model.ElementID;
            this.BtnNew.Action = "OnNew";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"2", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","133382f2-b79a-4d11-8612-541e58848d7f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "OnDelete";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutPut = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutPut", "True", "True", 35, 28,"4", "O",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","a978c2f7-2c5f-46db-a1da-5093fe3efa09");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutPut);
            this.BtnOutPut.UIModel = this.Model.ElementID;
            this.BtnOutPut.Action = "OnOutPut";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"5", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","d021a47d-6b1e-4133-8e0d-d11655d242d4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "OnPrint";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","c1a90ca0-1a8f-4be3-ae0d-309d2c739590");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 17, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(114,bool.Parse("True")),new GridColumnDef(117,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 80, 20, 13, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","d73efa8e-1937-401d-8207-9903366377ff");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "2");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 15, 0, 1, 1, "100",true,false,"","","1f0973e8-6597-4a04-8007-d6a6c059b657");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLCase, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLCase, _UFCard);
			this.DDLCase.ContentChanged += new EventHandler(DDLCase_TextChanged);
			this.DDLCase.AutoPostBack = true;
		

		
			UIControlBuilder.BuilderUFControl(this.DDLCase, "3");		
		 

				this.OnLookCase = UIControlBuilder.BuilderUFButton(_UFCard, true, "OnLookCase", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnLookCase",false,"2fae1c13-5d85-452d-bda2-a85a69b7f12c","2fae1c13-5d85-452d-bda2-a85a69b7f12c","7c791d0e-dfac-40f5-9f37-9ce48091dee0");
	

		
			UIControlBuilder.BuilderUFControl(this.OnLookCase, "1");		



			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","4407258f-bd43-4baa-802d-b432cac876a9");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(415,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,18,true, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 421, 0, 0, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  null, "", "", null, 18, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



        }





		#endregion
		
		 

		  
        #region BE列表自动生成代码

		private void AfterOnLoad_Qry_DefaultImpl()
		{
			IUIModelProperty mp = this.Model.Properties[UFIDA.UBF.Query.CommonService.QuerySymbol.NeedRefresh];
			if ((mp != null && (bool)mp.Value == true) || !Page.IsPostBack)
			{
				this.Action.QueryAdjust();
				if (mp != null)
				{
					mp.Value = false;
				}
			}
			else
			{
				QryService.SetGridWidthToCase(this.CurrentState, FormID, this.DataGrid1);
			}
		}

		private void AfterCreateChildControls_Qry_DefaultImpl(string bindViewName)
		{
			QryService.GridBindView(this.DataGrid1, bindViewName);
			AttachMakePageEvent();
		}

		private void AfterCreateChildControls_Qry_DefaultImpl()
		{
			QryService.GridBindView(this.DataGrid1, Action.MainView.Name);
			AttachMakePageEvent();
		}

		private void AttachMakePageEvent()
		{
			string message = UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo();
			PDFormMessage.ShowDelConfirmDialog(this.Page, message, "", this.BtnDelete);
			QryService.AttachMakePageEvent(this.Action, this.DataGrid1);
		}

		private void AfterUIModelBinding_Qry_DefaultImpl()
		{
			QryService.BindEnum("DDLCase", this, "b0832f38-673c-4beb-901c-8d69b00a8110");
		}

        #endregion
		 

	}
}
