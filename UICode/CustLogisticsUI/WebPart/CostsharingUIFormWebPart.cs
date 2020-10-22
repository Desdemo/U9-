


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


/***********************************************************************************************
 * Form ID:e10e8c94-b8d6-40c1-98d3-38034456c854 
 * Form Name:CostsharingUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
	[FormRegister("UFIDA.U9.Cust.BLT.CustLogisticsUI","UFIDA.U9.Cust.BLT.CustLogisticsUI.CostsharingUIFormWebPart", "UFIDA.U9.Cust.BLT.CustLogisticsUI.WebPart", "e10e8c94-b8d6-40c1-98d3-38034456c854","WebPart", "False", 624, 264)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.BLT.CustLogisticsUI', 'UFIDA.U9.Cust.BLT.CustLogisticsUI.CostsharingUIFormWebPart', 'UFIDA.U9.Cust.BLT.CustLogisticsUI.WebPart', 'e10e8c94-b8d6-40c1-98d3-38034456c854')
	///<siteMapNode url="~/erp/simple.aspx?lnk=e10e8c94-b8d6-40c1-98d3-38034456c854" title="CostsharingUIForm"/>
    public partial class CostsharingUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CostsharingUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new CostsharingUIModelAction Action
		{
			get { return (CostsharingUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		CostsharingUIModelModel _uimodel=null;
		public new CostsharingUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new CostsharingUIModelModel();
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
                this.Model = value as CostsharingUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFDataGrid DataGrid0;
        IUFCard Card0;
        IUFButton CostsharingAction185;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public CostsharingUIFormWebPart()
        {
            FormID = "e10e8c94-b8d6-40c1-98d3-38034456c854";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.CostsharingAction185.Click += new EventHandler(CostsharingAction185_Click);		
						

	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid0).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid0_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid0).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid0_GridCustomFilterHandler);

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
					this.Model = new CostsharingUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (CostsharingUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new CostsharingUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"CostsharingUIForm",true,624,264);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 2, 0, 10, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(600,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(200,bool.Parse("False")),new GridRowDef(30,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_DataGrid0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "0");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "0");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,false,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 600, 200, 0, 0, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.CostsharingView, "CostsharingView", "", null, 20, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.CostsharingView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","1137925b-a57f-4a60-b64d-c88de0513f5d","1137925b-a57f-4a60-b64d-c88de0513f5d","94300577-45f3-4207-a87e-40534ff99592");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion0","NumberColumnModel", "", 0,this.Model.CostsharingView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","e8bec691-8a76-4345-a3fb-b2618f412112","e8bec691-8a76-4345-a3fb-b2618f412112","4e3b57e4-3985-4793-bfde-7c2c6722b04a");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DocType0","DropDownListColumnModel", "", 0,this.Model.CostsharingView.Fields["DocType"]/*DocType*/,"DocType", false, true, true, false, false, false, 2, 100, "10.0",true, false,"","f82bd9e6-09f2-4399-b1b6-60ab6c41a42a","f82bd9e6-09f2-4399-b1b6-60ab6c41a42a","8bed8be1-3e4e-416a-9858-ff7f9240e353");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DocNo0","TextBoxColumnModel", "", 0,this.Model.CostsharingView.Fields["DocNo"]/*DocNo*/,"DocNo", false, true, true, false, false, false, 0, 100, "50",true, false,"","c1a2064d-e021-463b-9d2f-4fe58384b00d","c1a2064d-e021-463b-9d2f-4fe58384b00d","d3408625-2cd1-4a59-8a64-4f1f62ad5a1c");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DocID0","NumberColumnModel", "", 0,this.Model.CostsharingView.Fields["DocID"]/*DocID*/,"DocID", false, false, true, false, false, false, 7, 100, "19.0",true, false,"","7e4b4e94-3f42-46fe-a971-c9103ebb3659","7e4b4e94-3f42-46fe-a971-c9103ebb3659","cb0988f4-3f28-41a4-8143-3379a2dad6c6");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Amount0","NumberColumnModel", "", 2,this.Model.CostsharingView.Fields["Amount"]/*Amount*/,"Amount", false, true, true, false, false, false, 11, 100, "53.0",true, false,"","0a93518b-7462-408c-81bd-02233d90218c","0a93518b-7462-408c-81bd-02233d90218c","7fe969a1-79ac-41e1-b792-3bd918e21ea0");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 
        }

	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "0","","e21006d9-4c04-47da-bcfe-5d2eaa82e8f4");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 600, 30, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 9, 1, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(25,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.CostsharingAction185 = UIControlBuilder.BuilderUFButton(_UFCard, true, "CostsharingAction185", true, true, 100, 25, 8, 0, 1, 1, "100","", this.Model.ElementID,"CostsharingAction",false,"28f03a81-5e53-46d6-af28-abde803168c0","28f03a81-5e53-46d6-af28-abde803168c0","a4295445-d920-47be-a7c6-5b492b5505b7");
	

		
			UIControlBuilder.BuilderUFControl(this.CostsharingAction185, "0");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
