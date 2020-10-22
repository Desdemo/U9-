


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
 * Form ID:5e0b237e-6f26-47fe-917f-cbdaf6f4f641 
 * Form Name:DynamicPriceUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
	[FormRegister("UFIDA.U9.Cust.BLT.CustLogisticsUI","UFIDA.U9.Cust.BLT.CustLogisticsUI.DynamicPriceUIFormWebPart", "UFIDA.U9.Cust.BLT.CustLogisticsUI.WebPart", "5e0b237e-6f26-47fe-917f-cbdaf6f4f641","WebPart", "True", 1024, 560)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.BLT.CustLogisticsUI', 'UFIDA.U9.Cust.BLT.CustLogisticsUI.DynamicPriceUIFormWebPart', 'UFIDA.U9.Cust.BLT.CustLogisticsUI.WebPart', '5e0b237e-6f26-47fe-917f-cbdaf6f4f641')
	///<siteMapNode url="~/erp/simple.aspx?lnk=5e0b237e-6f26-47fe-917f-cbdaf6f4f641" title="DynamicPriceUIForm"/>
    public partial class DynamicPriceUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(DynamicPriceUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new DynamicPriceUIModelAction Action
		{
			get { return (DynamicPriceUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		DynamicPriceUIModelModel _uimodel=null;
		public new DynamicPriceUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new DynamicPriceUIModelModel();
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
                this.Model = value as DynamicPriceUIModelModel;
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
        IUFLabel lblDynamicPriceType2;
        IUFFldDropDownList DynamicPriceType2;
        IUFLabel lblID2;
        IUFFldNumberControl ID2;
        IUFLabel lblSysVersion2;
        IUFFldNumberControl SysVersion2;
        IUFLabel lblCode1;
        IUFFldTextBox Code1;
        IUFLabel lblUom1;
        IUFFldReference Uom1;
        IUFLabel lblRemark2;
        IUFFldTextBox Remark2;
        IUFLabel lblEffectField161;
        IUFFldDropDownList EffectField161;
        IUFLabel lblName71;
        IUFFldTextBox Name71;
        IUFDataGrid DataGrid5;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public DynamicPriceUIFormWebPart()
        {
            FormID = "5e0b237e-6f26-47fe-917f-cbdaf6f4f641";
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
					this.Model = new DynamicPriceUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (DynamicPriceUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new DynamicPriceUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"DynamicPriceUIForm",true,1024,560);
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
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","41a93e57-6429-4d69-b239-d2065ca4706f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","1b3dc099-106a-4634-8232-d336a00f11a8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","a7f211a6-5c49-48d2-947f-a4d3a37d382a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","0f06fa4f-546f-4373-ba19-fbe75e1d9d3c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","4d19e3ea-764b-4337-a2ec-9e0c37cd494b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "False", 35, 28,"8", "",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","39be153c-326a-4965-b32e-8b7e1efb3a6d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "False", 35, 28,"9", "",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","f8d23e10-e832-44b1-a73c-f7c6ca4bcca2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "False", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","0e5eaf3f-9470-4507-9862-45e00f5e62a5");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","7ea3ff00-12ce-434e-b942-393c1c55f463");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","60b4ad2a-6dfd-4272-99f9-82bdfae85013");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","b25835e7-4fde-4705-b644-6173bc7746ac");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", "",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","e57a4d27-5e2c-48a5-9b71-88579f3b1bd1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", "",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","ae9a9bf3-468f-4b1b-b7ae-40c54baa46cc");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","9db6af44-1ba9-4e47-9902-c24c4c02532a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","af420c41-d28c-4d69-881e-97c84c9ef086");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","78f677ad-db0e-4ace-8b9d-3dcfe58e030b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","1e18d43c-f66f-43f8-af85-b2fb93254dd1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","2f71ed99-d3ae-4d97-9266-93656b5d9080");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","78635916-f3de-4647-b230-c3ed1c72afe3");
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


				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, false, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","8beadc5d-ec51-47d0-9b09-3d82fcfcb577");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, false, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","ac6254c7-9ba5-4723-be75-c3b848ee53f1");
	

		
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
            , 80, 20, 0, 0, 1, 1, "100","c4e31736-3819-479a-9f0a-2a306ba44bec","3e28bbf6-d482-4d77-ba84-6fe2e308f84c");
            this.DDBtnOperation = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnActivity(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnActivity",false, true,"2"
            , 80, 20, 0, 0, 1, 1, "100","d24eab78-82b5-4f55-aa4a-f1c85a2c0489","f0ef1ac3-49f6-4008-949a-64604cbbc4c0");
            this.DDBtnActivity = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnQuery(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnQuery",false, true,"3"
            , 80, 20, 0, 0, 1, 1, "100","61a151e6-462e-4392-b264-c988ddd844b8","8dc62f37-bab5-4c09-a593-5c0f5a4825ce");
            this.DDBtnQuery = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnTaskLink(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnTaskLink",false, true,"8"
            , 80, 20, 0, 0, 1, 1, "100","e9b85406-d7e2-41f5-94da-49a69f06327c","006b3cb0-6615-4b79-afce-c8766f1a3b85");
            this.DDBtnTaskLink = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton11(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton11",false, true,"5"
            , 80, 20, 0, 0, 1, 1, "100","","633e8cc0-1894-47dd-a128-4fab0562884f");
            this.DropDownButton11 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton13(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton13",false, true,"6"
            , 80, 20, 0, 0, 1, 1, "100","","ea16bcaf-0e7c-4610-a648-ad6c8940d9e6");
            this.DropDownButton13 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton15(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton15",false, true,"7"
            , 80, 20, 0, 0, 1, 1, "100","","d70b10cc-f1d6-4727-857d-db9f0370bfa2");
            this.DropDownButton15 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton12(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton12",false, true,"4"
            , 80, 20, 0, 0, 1, 1, "100","","024817a4-704d-4faf-b7ca-256780a2186a");
            this.DropDownButton12 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","89700a38-465b-4c99-8d76-3213eef06584");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","1a48ef29-5e20-496a-9b0d-73f0a7188e95","3f4290e3-0b53-4a8d-904b-493c7bea2bbc");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 72, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.DynamicPrice, "DynamicPrice", "", null, 1, "动态价格");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblDynamicPriceType2 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDynamicPriceType2", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","1a48ef29-5e20-496a-9b0d-73f0a7188e95","9a6846bd-8c08-4b0e-86ba-7e3bb4d9a51b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDynamicPriceType2, "12");		


		        this.DynamicPriceType2 = UIControlBuilder.BuilderDropDownList(_UFCard, "DynamicPriceType2", "UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum", true,  true, true, "Left", 2, 60, 0, 153, 20, 2, 2, 1, 1, "100",true,false,"lblDynamicPriceType2","1a48ef29-5e20-496a-9b0d-73f0a7188e95","6095dbc9-2cfb-4543-91e0-7f4bb7d3b9da");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DynamicPriceType2, "False", "DynamicPriceType", this.Model.DynamicPrice, this.Model.DynamicPrice.FieldDynamicPriceType, "DynamicPrice");
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.DynamicPriceTypeEnum");
			EnumControlsMap.Add(this.DynamicPriceType2, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DynamicPriceType2, "13");		
		 

				this.lblID2 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID2", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","eda15da5-a6ad-43d7-9bd7-9d9fd5644822","21e448bc-6b0d-43f0-9eed-0883d1f8a9f8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID2, "14");		


				this.ID2 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID2", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID2","19.0","eda15da5-a6ad-43d7-9bd7-9d9fd5644822","4934053f-eb72-455c-95bc-fa07534b03c9",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID2, "False", "ID", this.Model.DynamicPrice, this.Model.DynamicPrice.FieldID, "DynamicPrice");
	
		
			UIControlBuilder.BuilderUFControl(this.ID2, "15");		
		 

				this.lblSysVersion2 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion2", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","546cf9a8-676e-41f6-b1c8-3cba5086cf03","a4363c34-4b67-4c7a-a0a5-d7b53da7990b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion2, "16");		


				this.SysVersion2 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion2", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion2","19.0","546cf9a8-676e-41f6-b1c8-3cba5086cf03","a85a9d46-e2b6-4900-a114-61b6cc328612",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion2, "False", "SysVersion", this.Model.DynamicPrice, this.Model.DynamicPrice.FieldSysVersion, "DynamicPrice");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion2, "17");		
		 

				this.lblCode1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCode1", "", "True", "True", "Right", 153, 20, 0, 0, 1, 1, "100","facaee8b-0721-4f61-97f0-9b7c3092f326","e4720a84-6d86-49cc-a3af-5a1e6e0199bd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCode1, "18");		


				this.Code1 = UIControlBuilder.BuilderTextBox(_UFCard, "Code1", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCode1","","50","facaee8b-0721-4f61-97f0-9b7c3092f326","ce21ede8-b873-46e9-a9b7-b2e2421ebda1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Code1, "False", "Code", this.Model.DynamicPrice, this.Model.DynamicPrice.FieldCode, "DynamicPrice");


		
			UIControlBuilder.BuilderUFControl(this.Code1, "19");		
		 

				this.lblUom1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblUom1", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","d91c4e64-0ebb-4c47-9c2f-6d29c85947b9","f266e2b0-5781-47e7-8421-4c41e3f9afaf");


								

		
			UIControlBuilder.BuilderUFControl(this.lblUom1, "20");		


				this.Uom1 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Uom1",true,true, true,153, 20, 2, 1, 1, 1, "100","21",false,false,true,"lblUom1","d91c4e64-0ebb-4c47-9c2f-6d29c85947b9","4b7320bf-c395-492d-8e39-e25ed5a1cf6b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Uom1, "False", "Uom", this.Model.DynamicPrice, this.Model.DynamicPrice.FieldUom, "DynamicPrice");
			UIControlBuilder.SetReferenceControlRefInfo(this.Uom1,"2cb04e9c-44df-44e8-b518-f1ce0ba1e2cd", 580,408, "Name","Code","ID", this.Model.DynamicPrice.FieldUom_Code,this.Model.DynamicPrice.FieldUom_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Uom1,"Uom1",new ReferenceInputParam[]{new ReferenceInputParam("DateTime1","","","",1),new ReferenceInputParam("DateTime2","","","",1),});
 			//for personal
		 				 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Uom1,"Uom1",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","UOMClass",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Round_Precision",""),new ReferenceOutputParam("","Round_RoundType",""),new ReferenceOutputParam("","Round_RoundValue",""),new ReferenceOutputParam("","BaseUOM_ID",""),new ReferenceOutputParam("","BaseUOM_Code",""),new ReferenceOutputParam("","BaseUOM_Name",""),new ReferenceOutputParam("","RatioToBase",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Uom1, "21");		
		 

				this.lblRemark2 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRemark2", "", "True", "True", "Right", 152, 20, 8, 0, 1, 1, "100","3de477fc-905f-486f-b06b-56985d180484","c5a7a062-3d7e-4a95-99b0-3ee131056144");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRemark2, "22");		


				this.Remark2 = UIControlBuilder.BuilderTextBox(_UFCard, "Remark2", "True", "True", "True", "True", "Left", 0, 60, 0, 152, 70, 10, 0, 1, 3, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblRemark2","","50","3de477fc-905f-486f-b06b-56985d180484","81ceb4f8-d49b-4f08-8642-3f9609b4ceeb");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Remark2, "False", "Remark", this.Model.DynamicPrice, this.Model.DynamicPrice.FieldRemark, "DynamicPrice");


		
			UIControlBuilder.BuilderUFControl(this.Remark2, "23");		
		 

				this.lblEffectField161 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffectField161", "", "True", "True", "Right", 152, 20, 4, 1, 1, 1, "100","532bd440-db16-4f8b-aaf9-43020bd3bb0c","8480e634-2ab0-428d-bc67-86508bb33eb3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffectField161, "24");		


		        this.EffectField161 = UIControlBuilder.BuilderDropDownList(_UFCard, "EffectField161", "UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum", true,  true, true, "Left", 2, 60, 0, 152, 20, 6, 1, 1, 1, "100",true,false,"lblEffectField161","532bd440-db16-4f8b-aaf9-43020bd3bb0c","694eb7f2-24fc-4be2-8f31-18ac745ac739");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.EffectField161, "False", "EffectField", this.Model.DynamicPrice, this.Model.DynamicPrice.FieldEffectField, "DynamicPrice");
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.EffectFieldEnum");
			EnumControlsMap.Add(this.EffectField161, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.EffectField161, "25");		
		 

				this.lblName71 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblName71", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","72cb8b5a-3782-4a3a-a858-9f255e5028f0","dc20ca2d-14cf-46e6-bd9a-722ce2d62188");


								

		
			UIControlBuilder.BuilderUFControl(this.lblName71, "26");		


				this.Name71 = UIControlBuilder.BuilderTextBox(_UFCard, "Name71", "True", "True", "True", "False", "Left", 0, 60, 0, 152, 20, 6, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblName71","","50","72cb8b5a-3782-4a3a-a858-9f255e5028f0","552e7e8d-eb6b-4293-a4bc-d22944655038");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Name71, "False", "Name", this.Model.DynamicPrice, this.Model.DynamicPrice.FieldName, "DynamicPrice");


		
			UIControlBuilder.BuilderUFControl(this.Name71, "27");		
		 


										
			this.Uom1.IsMultiOrg  = false ;
			this.lblUom1.SetMultiOrgInfo(this.Uom1,false);
			
						

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 339, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.DynamicPrice_DynamicPriceLine, "DynamicPrice_DynamicPriceLine", "", null, 20, "动态价格.Misc.动态价格行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID3","NumberColumnModel", "", 0,this.Model.DynamicPrice_DynamicPriceLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","8c7473ef-c136-4435-a242-75e44d067f74","8c7473ef-c136-4435-a242-75e44d067f74","a5800531-ec02-4b56-8fd6-0fe873a90ba9");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion3","NumberColumnModel", "", 0,this.Model.DynamicPrice_DynamicPriceLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","5fd96ae1-42c9-4efc-babd-6fd08f437c26","5fd96ae1-42c9-4efc-babd-6fd08f437c26","54916301-23a9-4c9d-af8b-3e4e1115ddfd");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"No1","NumberColumnModel", "", 0,this.Model.DynamicPrice_DynamicPriceLine.Fields["No"]/*No*/,"No", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","69eba915-8041-4927-a2ab-6baadc60dd99","69eba915-8041-4927-a2ab-6baadc60dd99","51502e48-a88c-4679-b4a0-a7290e70d91a");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",true,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UnitPrice1","NumberColumnModel", "", 2,this.Model.DynamicPrice_DynamicPriceLine.Fields["UnitPrice"]/*UnitPrice*/,"UnitPrice", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","6106a393-4b9f-4afa-aa91-5d5e60491dfa","6106a393-4b9f-4afa-aa91-5d5e60491dfa","23baadd0-64b7-4604-b927-e9c3ca2c5adb");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Start1","NumberColumnModel", "", 0,this.Model.DynamicPrice_DynamicPriceLine.Fields["Start"]/*Start*/,"Start", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","60174dba-46fc-4521-900e-f263e32a8840","60174dba-46fc-4521-900e-f263e32a8840","1afb875c-dbf3-45af-9205-f99e4faf6b56");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, 0m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Cutoff1","NumberColumnModel", "", 0,this.Model.DynamicPrice_DynamicPriceLine.Fields["Cutoff"]/*Cutoff*/,"Cutoff", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","7dd3fbe6-ab7d-428a-b8a2-393e3dde3f1d","7dd3fbe6-ab7d-428a-b8a2-393e3dde3f1d","e110cb80-3bc0-4931-8098-831977524a81");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, 0m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Total1","NumberColumnModel", "", 0,this.Model.DynamicPrice_DynamicPriceLine.Fields["Total"]/*Total*/,"Total", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","565e94a0-d014-43e2-a41e-31698bb23aaa","565e94a0-d014-43e2-a41e-31698bb23aaa","444f1da2-918e-452c-9678-6bca74cbe3b2");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"Cutoff - Start",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Remark3","TextBoxColumnModel", "", 0,this.Model.DynamicPrice_DynamicPriceLine.Fields["Remark"]/*Remark*/,"Remark", false, true, true, false, false, true, 0, 100, "50",true, false,"","12690aaa-eab8-4ba1-89ef-f543b74e389d","12690aaa-eab8-4ba1-89ef-f543b74e389d","e3378d8c-17f4-47ee-8b89-c81c5140ed88");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}
