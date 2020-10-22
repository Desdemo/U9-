


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
 * Form ID:9a59029b-a006-4490-9d08-5806abbf2df3 
 * Form Name:LogisticsPricelistUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
	[FormRegister("UFIDA.U9.Cust.BLT.CustLogisticsUI","UFIDA.U9.Cust.BLT.CustLogisticsUI.LogisticsPricelistUIFormWebPart", "UFIDA.U9.Cust.BLT.CustLogisticsUI.WebPart", "9a59029b-a006-4490-9d08-5806abbf2df3","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.BLT.CustLogisticsUI', 'UFIDA.U9.Cust.BLT.CustLogisticsUI.LogisticsPricelistUIFormWebPart', 'UFIDA.U9.Cust.BLT.CustLogisticsUI.WebPart', '9a59029b-a006-4490-9d08-5806abbf2df3')
	///<siteMapNode url="~/erp/simple.aspx?lnk=9a59029b-a006-4490-9d08-5806abbf2df3" title="LogisticsPricelistUIForm"/>
    public partial class LogisticsPricelistUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LogisticsPricelistUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new LogisticsPricelistUIModelAction Action
		{
			get { return (LogisticsPricelistUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		LogisticsPricelistUIModelModel _uimodel=null;
		public new LogisticsPricelistUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new LogisticsPricelistUIModelModel();
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
                this.Model = value as LogisticsPricelistUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar2;
        IUFButton BtnSave;
        IUFButton BtnCancel;
        IUFButton BtnAdd;
        IUFButton BtnDelete;
        IUFSeparator Separator0;
        IUFButton BtnCopy;
        IUFSeparator Separator1;
        IUFButton BtnSubmit;
        IUFButton BtnApprove;
        IUFButton BtnUndoApprove;
        IUFSeparator Separator2;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFButton BtnAttachment;
        IUFButton BtnFlow;
        IUFSeparator Separator5;
        IUFButton BtnOutput;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFDropDownButton DDBtnOperation;
        IUFDropDownButton DDBtnActivity;
        IUFDropDownButton DDBtnQuery;
        IUFDropDownButton DDBtnTaskLink;
        IUFButton BtnOk;
        IUFButton BtnClose;
        IUFDropDownButton DropDownButton11;
        IUFDropDownButton DropDownButton13;
        IUFDropDownButton DropDownButton15;
        IUFDropDownButton DropDownButton12;
        IUFCard Card4;
        IUFCard Card2;
        IUFLabel lblID0;
        IUFFldNumberControl ID0;
        IUFLabel lblSysVersion0;
        IUFFldNumberControl SysVersion0;
        IUFLabel lblCode1;
        IUFFldTextBox Code1;
        IUFLabel lblName0;
        IUFFldTextBox Name0;
        IUFLabel lblSup0;
        IUFFldReference Sup0;
        IUFLabel lblCurrency0;
        IUFFldReference Currency0;
        IUFDataGrid DataGrid5;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public LogisticsPricelistUIFormWebPart()
        {
            FormID = "9a59029b-a006-4490-9d08-5806abbf2df3";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnSave.Click += new EventHandler(BtnSave_Click);		
						
				//Button控件事件
			this.BtnCancel.Click += new EventHandler(BtnCancel_Click);		
						
				//Button控件事件
			this.BtnAdd.Click += new EventHandler(BtnAdd_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnCopy.Click += new EventHandler(BtnCopy_Click);		
						
				//Button控件事件
			this.BtnSubmit.Click += new EventHandler(BtnSubmit_Click);		
						
				//Button控件事件
			this.BtnApprove.Click += new EventHandler(BtnApprove_Click);		
						
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnList.Click += new EventHandler(BtnList_Click);		
						
				//Button控件事件
			this.BtnFirstPage.Click += new EventHandler(BtnFirstPage_Click);		
						
				//Button控件事件
			this.BtnPrevPage.Click += new EventHandler(BtnPrevPage_Click);		
						
				//Button控件事件
			this.BtnNextPage.Click += new EventHandler(BtnNextPage_Click);		
						
				//Button控件事件
			this.BtnLastPage.Click += new EventHandler(BtnLastPage_Click);		
						
				//Button控件事件
			this.BtnAttachment.Click += new EventHandler(BtnAttachment_Click);		
						
				//Button控件事件
			this.BtnFlow.Click += new EventHandler(BtnFlow_Click);		
						
				//Button控件事件
			this.BtnOutput.Click += new EventHandler(BtnOutput_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid5).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid5_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid5).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid5_GridCustomFilterHandler);

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
					this.Model = new LogisticsPricelistUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (LogisticsPricelistUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
				//BtnFind对应隐藏域的数据传递。:True
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.BindingBtnFindParam(this);
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
            this.Action = new LogisticsPricelistUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"LogisticsPricelistUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","5849d4f2-75d6-4054-a0fd-121d0255b564");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","560098dd-d822-46f6-ab22-ebf756392019");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","669937cb-6efd-47cd-8ded-3f537568c64a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","f4bf050b-720e-44c3-b24a-ee17c52edffd");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","91585e0c-e221-454d-8d42-0a520776b2a8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "False", 35, 28,"8", "",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","728bd1eb-df7b-46fc-ac43-fe8b3e4291db");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "False", 35, 28,"9", "",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","615f60fa-7177-4011-b8d5-aa36cf6dd87e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "False", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","34ceda8d-3185-4142-84ae-c27abacee24c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","5c5e03c3-5577-4352-917c-0387c06be0f4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","e5e2b932-cc62-4f9a-9e1c-d6ca2ef5c14b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","14e0a785-fd65-46ca-9799-f447fe758f44");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", "",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","2cb76892-fc09-4046-9a08-bd17ac442746");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", "",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","6e7fdb97-85ec-43a8-a9f5-6fcff972e85d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","7ed38ce5-c59d-4990-a398-94c9544615da");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","d9c6c278-6572-4f81-9163-60f4098bb91f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","098bfc16-0e0c-48e1-bb8e-2b6c0b173b5e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","191fdd85-45ae-4658-8712-9e98d2f39830");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","b9b97272-c11b-4cec-9abe-4bae35d651c6");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","d7c6e970-1cf1-4114-be20-0771881665be");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DDBtnOperation(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnOperation, "1");		


	
			_BuilderControl_DDBtnActivity(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnActivity, "2");		


	
			_BuilderControl_DDBtnQuery(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnQuery, "3");		


	
			_BuilderControl_DDBtnTaskLink(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnTaskLink, "8");		


				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, false, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","9d29dfdd-c160-4593-a29f-45c5f778fa0b");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, false, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","88e14c71-f100-4776-8f91-08d858aac72d");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "10");		


	
			_BuilderControl_DropDownButton11(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton11, "5");		


	
			_BuilderControl_DropDownButton13(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton13, "6");		


	
			_BuilderControl_DropDownButton15(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton15, "7");		


	
			_BuilderControl_DropDownButton12(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton12, "4");		



										

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				       
        private void _BuilderControl_DDBtnOperation(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnOperation",false, true,"1"
            , 80, 20, 0, 0, 1, 1, "100","c4e31736-3819-479a-9f0a-2a306ba44bec","c03e547f-f89e-4c7f-a45f-8455e44702c7");
            this.DDBtnOperation = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnActivity(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnActivity",false, true,"2"
            , 80, 20, 0, 0, 1, 1, "100","d24eab78-82b5-4f55-aa4a-f1c85a2c0489","e8ef621b-cbe7-48bd-9a9b-73cd579f4705");
            this.DDBtnActivity = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnQuery(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnQuery",false, true,"3"
            , 80, 20, 0, 0, 1, 1, "100","61a151e6-462e-4392-b264-c988ddd844b8","6b33ea82-7bb3-49b6-91b6-0076deef09a3");
            this.DDBtnQuery = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnTaskLink(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnTaskLink",false, true,"8"
            , 80, 20, 0, 0, 1, 1, "100","e9b85406-d7e2-41f5-94da-49a69f06327c","f47d6dfb-30f7-4505-a17f-031dd87771a2");
            this.DDBtnTaskLink = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton11(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton11",false, true,"5"
            , 80, 20, 0, 0, 1, 1, "100","","0aed118e-d70d-426a-b50f-81280b0340f7");
            this.DropDownButton11 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton13(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton13",false, true,"6"
            , 80, 20, 0, 0, 1, 1, "100","","49ebde0a-ab22-42d0-a071-8ec16f6d7965");
            this.DropDownButton13 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton15(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton15",false, true,"7"
            , 80, 20, 0, 0, 1, 1, "100","","b7c7b3dd-9770-4c2f-bc28-02469d5be5b7");
            this.DropDownButton15 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton12(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton12",false, true,"4"
            , 80, 20, 0, 0, 1, 1, "100","","6f8405e3-d862-4b82-97a6-2cfb36ed82c5");
            this.DropDownButton12 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","b15132bc-93b9-49c1-9ae9-9e16c744efd5");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(72,bool.Parse("True")),new GridRowDef(328,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_Card2(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "1");		


	
			_BuilderControl_DataGrid5(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid5, "2");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","298d69bb-f313-48d9-915d-6c90413c7779","a54245bd-7fc3-4087-9c49-74b10997a4b2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 72, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.LogisticsPricelist, "LogisticsPricelist", "", null, 1, "物流价目表");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID0", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","298d69bb-f313-48d9-915d-6c90413c7779","45ebb323-b6a8-4043-9ab5-a88fe69c6f86");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID0, "0");		


				this.ID0 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID0", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID0","19.0","298d69bb-f313-48d9-915d-6c90413c7779","11242abb-0347-40dc-887a-b8082b1034d3",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID0, "False", "ID", this.Model.LogisticsPricelist, this.Model.LogisticsPricelist.FieldID, "LogisticsPricelist");
	
		
			UIControlBuilder.BuilderUFControl(this.ID0, "1");		
		 

				this.lblSysVersion0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion0", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","a2ef34d2-cfe8-439d-b19b-80cad5057f2c","213341c7-d764-4613-a0dc-57c673250768");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion0, "2");		


				this.SysVersion0 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion0", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion0","19.0","a2ef34d2-cfe8-439d-b19b-80cad5057f2c","34915cce-119c-4547-88c3-34f44bd67e7a",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion0, "False", "SysVersion", this.Model.LogisticsPricelist, this.Model.LogisticsPricelist.FieldSysVersion, "LogisticsPricelist");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion0, "3");		
		 

				this.lblCode1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCode1", "", "True", "True", "Right", 153, 20, 0, 0, 1, 1, "100","8a7bc2c9-3b4a-41fa-8166-394235f92961","33ec01bc-328a-42c7-9c63-c586d590239f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCode1, "4");		


				this.Code1 = UIControlBuilder.BuilderTextBox(_UFCard, "Code1", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCode1","","50","8a7bc2c9-3b4a-41fa-8166-394235f92961","2b7dcecc-1dd7-4831-9d41-12794b5ba16b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Code1, "False", "Code", this.Model.LogisticsPricelist, this.Model.LogisticsPricelist.FieldCode, "LogisticsPricelist");


		
			UIControlBuilder.BuilderUFControl(this.Code1, "5");		
		 

				this.lblName0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblName0", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","7ae2d7d1-30dd-452d-904b-ac73e80d8f64","7121e900-6bed-4398-8715-235e1dd5cf63");


								

		
			UIControlBuilder.BuilderUFControl(this.lblName0, "6");		


				this.Name0 = UIControlBuilder.BuilderTextBox(_UFCard, "Name0", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblName0","","50","7ae2d7d1-30dd-452d-904b-ac73e80d8f64","2b9d2675-4256-4cbf-af6f-6169e082a06c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Name0, "False", "Name", this.Model.LogisticsPricelist, this.Model.LogisticsPricelist.FieldName, "LogisticsPricelist");


		
			UIControlBuilder.BuilderUFControl(this.Name0, "7");		
		 

				this.lblSup0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSup0", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","87202b0c-5de2-4f7c-aa67-b7ef0d0ff10b","c3118301-dafe-4e9d-a0ec-ecd15e0adfe1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSup0, "8");		


				this.Sup0 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Sup0",true,true, true,153, 20, 2, 2, 1, 1, "100","9",false,false,true,"lblSup0","87202b0c-5de2-4f7c-aa67-b7ef0d0ff10b","a293a4a7-a363-4b39-bfdf-fd6e63a38a81");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Sup0, "False", "Sup", this.Model.LogisticsPricelist, this.Model.LogisticsPricelist.FieldSup, "LogisticsPricelist");
			UIControlBuilder.SetReferenceControlRefInfo(this.Sup0,"ea01ca72-c3a4-4563-b9b9-d47c720f051c", 580,408, "Name","Code","ID", this.Model.LogisticsPricelist.FieldSup_Code,this.Model.LogisticsPricelist.FieldSup_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Sup0,"Sup0",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","Category_Name",""),new ReferenceOutputParam("","Territory_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Sup0, "9");		
		 

				this.lblCurrency0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCurrency0", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","104c808d-dce1-49b8-92af-ce497efb33bf","6ccf69e0-952d-4445-8ff0-ef07e34ca2fd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCurrency0, "10");		


				this.Currency0 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Currency0",true,true, true,152, 20, 6, 0, 1, 1, "100","11",false,false,true,"lblCurrency0","104c808d-dce1-49b8-92af-ce497efb33bf","cc4fed4b-a324-4d3c-a551-e985a1e7c08f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Currency0, "False", "Currency", this.Model.LogisticsPricelist, this.Model.LogisticsPricelist.FieldCurrency, "LogisticsPricelist");
			UIControlBuilder.SetReferenceControlRefInfo(this.Currency0,"27f276ae-3cd1-49bc-9e3b-2f3b938bc4d0", 580,408, "Name","Code","ID", this.Model.LogisticsPricelist.FieldCurrency_Code,this.Model.LogisticsPricelist.FieldCurrency_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Currency0,"Currency0",new ReferenceInputParam[]{new ReferenceInputParam("DateTime1","","","",1),new ReferenceInputParam("DateTime2","","","",1),});
 			//for personal
		 				 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Currency0,"Currency0",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","ISOCode",""),new ReferenceOutputParam("","Symbol",""),new ReferenceOutputParam("","PriceRound_Precision",""),new ReferenceOutputParam("","PriceRound_RoundType",""),new ReferenceOutputParam("","PriceRound_RoundValue",""),new ReferenceOutputParam("","MoneyRound_Precision",""),new ReferenceOutputParam("","MoneyRound_RoundType",""),new ReferenceOutputParam("","MoneyRound_RoundValue",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Currency0, "11");		
		 


										
			this.Sup0.IsMultiOrg  = false ;
			this.lblSup0.SetMultiOrgInfo(this.Sup0,false);
			
		
			this.Currency0.IsMultiOrg  = false ;
			this.lblCurrency0.SetMultiOrgInfo(this.Currency0,false);
			


            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 339, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.LogisticsPricelist_LogisticsPricelistLine, "LogisticsPricelist_LogisticsPricelistLine", "", null, 20, "物流价目表.Misc.实体");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"No0","NumberColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["No"]/*No*/,"No", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","b4e92ac5-327c-4996-a4b7-16ebd0ad56e5","b4e92ac5-327c-4996-a4b7-16ebd0ad56e5","94ac3d8f-e055-4095-8bc0-dc395a325875");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",true,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DeliveryFactory0","DropDownListColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["DeliveryFactory"]/*DeliveryFactory*/,"DeliveryFactory", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","5b6b438f-203d-4d38-ad9b-d2e856fbcfe1","5b6b438f-203d-4d38-ad9b-d2e856fbcfe1","5a0db998-0650-401b-bd52-fb51427765bd");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Address0","ReferenceColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["Address"]/*Address*/,"Address", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","0a27568d-2d4c-4c12-afa0-9ffab2f701c3","0a27568d-2d4c-4c12-afa0-9ffab2f701c3","2f02d2c2-32c1-40bf-93ef-c5a7b9a5d0f2");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldAddress_Code/*Address_Code*/, this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldAddress_Name/*Address_Name*/, "1eff2146-d07b-4ab6-b6c4-323e5e6b5185"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "2f02d2c2-32c1-40bf-93ef-c5a7b9a5d0f2";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FormatAddress0","TextBoxColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["FormatAddress"]/*FormatAddress*/,"FormatAddress", false, true, true, false, false, true, 0, 100, "50",true, false,"","9a0de70c-a761-4f36-b81c-2af6bc569e21","9a0de70c-a761-4f36-b81c-2af6bc569e21","f43b6dc4-62fa-463e-a161-82ad73da9d29");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Province0","ReferenceColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["Province"]/*Province*/,"Province", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","06ae0622-c3ea-4e4a-9555-451046726ba0","06ae0622-c3ea-4e4a-9555-451046726ba0","4b569e8d-d83e-47be-998a-f580f44c8d36");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldProvince_Code/*Province_Code*/, this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldProvince_Name/*Province_Name*/, "78dbf747-68e4-40ee-92f4-dc02b306f0be"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "4b569e8d-d83e-47be-998a-f580f44c8d36";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							

						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"City0","ReferenceColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["City"]/*City*/,"City", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","9b16cb05-ff5e-45b9-8ef4-fdd55d3a4586","9b16cb05-ff5e-45b9-8ef4-fdd55d3a4586","03a351cd-0bc1-4028-85fc-d4cd5667b8de");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldCity_Code/*City_Code*/, this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldCity_Name/*City_Name*/, "5174325f-c5c7-467c-8ff6-a439e93d3636"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "03a351cd-0bc1-4028-85fc-d4cd5667b8de";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							



						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"County0","ReferenceColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["County"]/*County*/,"County", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","a0e16a4c-6273-49b5-929d-b5456c06d1a3","a0e16a4c-6273-49b5-929d-b5456c06d1a3","b2c2677a-f177-4eb9-bec5-7bc0516ab7dd");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldCounty_Code/*County_Code*/, this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldCounty_Name/*County_Name*/, "5f79932a-c9fc-4036-a888-c330278610b7"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "b2c2677a-f177-4eb9-bec5-7bc0516ab7dd";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							





						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DescribeAddress0","TextBoxColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["DescribeAddress"]/*DescribeAddress*/,"DescribeAddress", false, true, true, false, false, true, 0, 100, "50",true, false,"","e64eae19-7b7c-44a3-8bec-c74c99cf3ddf","e64eae19-7b7c-44a3-8bec-c74c99cf3ddf","69fa734d-b9a7-4b1f-bfc7-b503e75ef41f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PricingMethod0","DropDownListColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["PricingMethod"]/*PricingMethod*/,"PricingMethod", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","19d05cbf-d8b2-4df7-ae6e-f938dad214ce","19d05cbf-d8b2-4df7-ae6e-f938dad214ce","9f332e6b-b9d5-46fe-888d-d1ff7f770169");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PricingUom0","ReferenceColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["PricingUom"]/*PricingUom*/,"PricingUom", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","7453a7c4-e639-4278-b3f3-acf0353de20a","7453a7c4-e639-4278-b3f3-acf0353de20a","2284b2ca-9478-476f-a638-813e71e73e28");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldPricingUom_Code/*PricingUom_Code*/, this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldPricingUom_Name/*PricingUom_Name*/, "2cb04e9c-44df-44e8-b518-f1ce0ba1e2cd"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "2284b2ca-9478-476f-a638-813e71e73e28";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							



						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DynamicPrice0","ReferenceColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["DynamicPrice"]/*DynamicPrice*/,"DynamicPrice", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","2d77cf8b-5cca-4cdc-b1ec-d6dd3ceeef8e","2d77cf8b-5cca-4cdc-b1ec-d6dd3ceeef8e","6deda1eb-dd77-495b-ae5c-1364908ec8b5");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Code", this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice_Code/*DynamicPrice_Code*/, this.Model.LogisticsPricelist_LogisticsPricelistLine.FieldDynamicPrice_Code/*DynamicPrice_Code*/, "4f63643c-eaa3-47d5-814f-a2ab498e13f0"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "6deda1eb-dd77-495b-ae5c-1364908ec8b5";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UintPrice0","NumberColumnModel", "", 2,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["UintPrice"]/*UintPrice*/,"UintPrice", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","6beaa2cc-188c-4e48-9f3a-508f6acca744","6beaa2cc-188c-4e48-9f3a-508f6acca744","b245189d-6c2e-49e6-8b2f-596f1f7907ac");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DeliveryPickup0","NumberColumnModel", "", 2,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["DeliveryPickup"]/*DeliveryPickup*/,"DeliveryPickup", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","770ef7b0-e196-4695-8c0b-2e4c89e96213","770ef7b0-e196-4695-8c0b-2e4c89e96213","f15d73ed-fb72-4af4-843f-f0ed46baa192");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FreePickup0","NumberColumnModel", "", 2,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["FreePickup"]/*FreePickup*/,"FreePickup", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","7262dd4b-0325-483a-b233-54ae487db552","7262dd4b-0325-483a-b233-54ae487db552","127cdfba-5346-428b-a730-e65fdbf445f3");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DeliveryCharges0","NumberColumnModel", "", 2,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["DeliveryCharges"]/*DeliveryCharges*/,"DeliveryCharges", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","531834b5-5240-4c28-bd0e-502966a3be52","531834b5-5240-4c28-bd0e-502966a3be52","1eaf6fe1-ac2f-4779-b971-31ead8ce46f5");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FreeDelivery0","NumberColumnModel", "", 2,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["FreeDelivery"]/*FreeDelivery*/,"FreeDelivery", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","913f7cc2-f224-4988-8520-0bc37ec71f08","913f7cc2-f224-4988-8520-0bc37ec71f08","8f939dd6-e10c-450f-95a1-693a58d59131");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Remark0","TextBoxColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["Remark"]/*Remark*/,"Remark", false, true, true, false, false, true, 0, 100, "50",true, false,"","e2c49acd-a3f1-4434-b654-1b90fe641891","e2c49acd-a3f1-4434-b654-1b90fe641891","86924b8a-f642-4776-b244-a7cfc4f97c04");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID1","NumberColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","b4509be9-16d0-428e-bd03-8a7438841e51","b4509be9-16d0-428e-bd03-8a7438841e51","9cc5dc9b-da2a-4ef1-8ee8-7333c027d53c");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion1","NumberColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","b6f296d7-a93a-45dd-a9b9-0574dc874c12","b6f296d7-a93a-45dd-a9b9-0574dc874c12","e1bd6147-7781-47e1-b6fd-f482a4a28b1b");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"TransportationTime0","TextBoxColumnModel", "", 0,this.Model.LogisticsPricelist_LogisticsPricelistLine.Fields["TransportationTime"]/*TransportationTime*/,"TransportationTime", false, true, true, false, false, true, 0, 100, "50",true, false,"","fc2c1bcf-6949-4220-8ddd-4abe26a93747","fc2c1bcf-6949-4220-8ddd-4abe26a93747","55aab98e-1c07-42c2-aca5-81f6cdd5f557");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}
