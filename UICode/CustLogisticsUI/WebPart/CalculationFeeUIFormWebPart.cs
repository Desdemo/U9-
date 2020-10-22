


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
 * Form ID:7f43d7fc-5c22-4f8d-b2ce-0043b5adc0b6 
 * Form Name:CalculationFeeUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.CustLogisticsUI
{
	[FormRegister("UFIDA.U9.Cust.BLT.CustLogisticsUI","UFIDA.U9.Cust.BLT.CustLogisticsUI.CalculationFeeUIFormWebPart", "UFIDA.U9.Cust.BLT.CustLogisticsUI.WebPart", "7f43d7fc-5c22-4f8d-b2ce-0043b5adc0b6","WebPart", "True", 1008, 664)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.BLT.CustLogisticsUI', 'UFIDA.U9.Cust.BLT.CustLogisticsUI.CalculationFeeUIFormWebPart', 'UFIDA.U9.Cust.BLT.CustLogisticsUI.WebPart', '7f43d7fc-5c22-4f8d-b2ce-0043b5adc0b6')
	///<siteMapNode url="~/erp/simple.aspx?lnk=7f43d7fc-5c22-4f8d-b2ce-0043b5adc0b6" title="CalculationFeeUIForm"/>
    public partial class CalculationFeeUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CalculationFeeUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new CalculationFeeUIModelAction Action
		{
			get { return (CalculationFeeUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		CalculationFeeUIModelModel _uimodel=null;
		public new CalculationFeeUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new CalculationFeeUIModelModel();
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
                this.Model = value as CalculationFeeUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar0;
        IUFButton OutputClick0;
        IUFSeparator Separator0;
        IUFButton AttachmentClick0;
        IUFSeparator Separator1;
        IUFButton FlowClick0;
        IUFSeparator Separator2;
        IUFButton PrintClick0;
        IUFCard Card0;
        IUFLabel lblID0;
        IUFFldNumberControl ID0;
        IUFLabel lblSysVersion0;
        IUFFldNumberControl SysVersion0;
        IUFLabel lblDeliveryFactory0;
        IUFFldDropDownList DeliveryFactory0;
        IUFLabel lblSup0;
        IUFFldReference Sup0;
        IUFLabel lblNumberOfTrucks0;
        IUFFldNumberControl NumberOfTrucks0;
        IUFLabel lblShipDate0;
        IUFFldDatePicker ShipDate0;
        IUFLabel lblContain0;
        IUFFldCheckBox Contain0;
        IUFLabel lblPricingMethod0;
        IUFFldDropDownList PricingMethod0;
        IUFButton Query0;
        IUFLabel lblSetLocation966;
        IUFFldReference SetLocation966;
        IUFLabel lblProvince0;
        IUFFldReference Province0;
        IUFLabel lblCity_Name1;
        IUFFldTextBox City_Name1;
        IUFLabel lblCounty_Name0;
        IUFFldTextBox County_Name0;
        IUFLabel lblDescriLocation0;
        IUFFldTextBox DescriLocation0;
        IUFLabel lblAddress257;
        IUFFldTextBox Address257;
        IUFDataGrid DataGrid0;
        IUFCard Card2;
        IUFLine Line0;
        IUFLabel lblID2;
        IUFFldNumberControl ID2;
        IUFLabel lblSysVersion2;
        IUFFldNumberControl SysVersion2;
        IUFLabel lblTotalBulk0;
        IUFFldNumberControl TotalBulk0;
        IUFLabel lblTotalWeight0;
        IUFFldNumberControl TotalWeight0;
        IUFLabel lblRealBulk0;
        IUFFldNumberControl RealBulk0;
        IUFLabel lblRealWeight0;
        IUFFldNumberControl RealWeight0;
        IUFLabel lblPickupFee0;
        IUFFldNumberControl PickupFee0;
        IUFLabel lblDeliveryFee0;
        IUFFldNumberControl DeliveryFee0;
        IUFLabel lblDischargeFee295;
        IUFFldNumberControl DischargeFee295;
        IUFLabel lblOtherFee129;
        IUFFldNumberControl OtherFee129;
        IUFLabel lblTotalFreight192;
        IUFFldNumberControl TotalFreight192;
        IUFLabel lblRealFreight179;
        IUFFldNumberControl RealFreight179;
        IUFCard Card3;
        IUFLine Line1;
        IUFLabel lblID3;
        IUFFldNumberControl ID3;
        IUFLabel lblSysVersion3;
        IUFFldNumberControl SysVersion3;
        IUFLabel lblTotalBulk2;
        IUFFldNumberControl TotalBulk2;
        IUFLabel lblTotalWeight1;
        IUFFldNumberControl TotalWeight1;
        IUFLabel lblRealBulk1;
        IUFFldNumberControl RealBulk1;
        IUFLabel lblRealWeight1;
        IUFFldNumberControl RealWeight1;
        IUFLabel lblPickupFee1;
        IUFFldNumberControl PickupFee1;
        IUFLabel lblDeliveryFee1;
        IUFFldNumberControl DeliveryFee1;
        IUFLabel lblDischargeFee296;
        IUFFldNumberControl DischargeFee296;
        IUFLabel lblOtherFee130;
        IUFFldNumberControl OtherFee130;
        IUFLabel lblTotalFreight193;
        IUFFldNumberControl TotalFreight193;
        IUFLabel lblRealFreight180;
        IUFFldNumberControl RealFreight180;
        IUFCard Card4;
        IUFLine Line2;
        IUFLabel lblTotalAmount0;
        IUFFldNumberControl TotalAmount0;
        IUFLabel lblUintPrice0;
        IUFFldNumberControl UintPrice0;
        IUFLabel lblRemark225;
        IUFFldTextBox Remark225;
        IUFLabel lblRealAmount1;
        IUFFldNumberControl RealAmount1;
        IUFCard Card5;
        IUFButton Complex0;
        IUFButton ManualCostsharing0;
        IUFButton Costsharing0;
        IUFButton SaveClick0;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public CalculationFeeUIFormWebPart()
        {
            FormID = "7f43d7fc-5c22-4f8d-b2ce-0043b5adc0b6";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.OutputClick0.Click += new EventHandler(OutputClick0_Click);		
						
				//Button控件事件
			this.AttachmentClick0.Click += new EventHandler(AttachmentClick0_Click);		
						
				//Button控件事件
			this.FlowClick0.Click += new EventHandler(FlowClick0_Click);		
						
				//Button控件事件
			this.PrintClick0.Click += new EventHandler(PrintClick0_Click);		
						
				//Button控件事件
			this.Query0.Click += new EventHandler(Query0_Click);		
						
				//Button控件事件
			this.Complex0.Click += new EventHandler(Complex0_Click);		
						
				//Button控件事件
			this.ManualCostsharing0.Click += new EventHandler(ManualCostsharing0_Click);		
						
				//Button控件事件
			this.Costsharing0.Click += new EventHandler(Costsharing0_Click);		
						
				//Button控件事件
			this.SaveClick0.Click += new EventHandler(SaveClick0_Click);		
						

		
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
					this.Model = new CalculationFeeUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (CalculationFeeUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new CalculationFeeUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"CalculationFeeUIForm",true,1008,664);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 7, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(950,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(25,bool.Parse("True")),new GridRowDef(80,bool.Parse("True")),new GridRowDef(250,bool.Parse("False")),new GridRowDef(80,bool.Parse("True")),new GridRowDef(80,bool.Parse("True")),new GridRowDef(60,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar0, "0");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "0");		


	
			_BuilderControl_DataGrid0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "1");		


	
			_BuilderControl_Card2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "0");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "0");		


	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "0");		


	
			_BuilderControl_Card5(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card5, "0");		



							
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar0(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar0",true, true, "0",950, 25, 0, 0, 1, 1,"100");
            this.Toolbar0 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.OutputClick0 = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "OutputClick0", "True", "True", 35, 25,"2", "O",true,false,"9ee5b3dd-c9b8-4197-b86e-a316377b6bed","9ee5b3dd-c9b8-4197-b86e-a316377b6bed","7be438cc-d254-4a69-b59c-aae77b71ef59");
		
            UIControlBuilder.SetButtonAccessKey(this.OutputClick0);
            this.OutputClick0.UIModel = this.Model.ElementID;
            this.OutputClick0.Action = "OutputClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.AttachmentClick0 = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "AttachmentClick0", "True", "True", 35, 25,"5", "A",true,false,"ad592b17-5cc5-45a0-8250-58f913360d47","ad592b17-5cc5-45a0-8250-58f913360d47","edda24f7-8b5b-4db8-b215-42025cb22032");
		
            UIControlBuilder.SetButtonAccessKey(this.AttachmentClick0);
            this.AttachmentClick0.UIModel = this.Model.ElementID;
            this.AttachmentClick0.Action = "AttachmentClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.FlowClick0 = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "FlowClick0", "True", "True", 35, 25,"1", "F",true,false,"cd5e289a-20b8-4096-924a-a193b72369bf","cd5e289a-20b8-4096-924a-a193b72369bf","1b4c948f-8931-498f-a2f1-72f01e1f0689");
		
            UIControlBuilder.SetButtonAccessKey(this.FlowClick0);
            this.FlowClick0.UIModel = this.Model.ElementID;
            this.FlowClick0.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.PrintClick0 = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "PrintClick0", "True", "True", 35, 25,"3", "P",true,false,"3d1364f8-e5f9-481e-8761-d84148f2b344","3d1364f8-e5f9-481e-8761-d84148f2b344","3723ed1f-5bd2-41f0-b200-9cedfd2ccd0c");
		
            UIControlBuilder.SetButtonAccessKey(this.PrintClick0);
            this.PrintClick0.UIModel = this.Model.ElementID;
            this.PrintClick0.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "0","3a6d58a1-db6f-4eae-ab32-ec7b8aa54970","c3e0020f-931b-4a75-9893-a7ef57ed86b8");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 950, 80, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 15, 3, 0, 5, 10, 5, 10, 5);
			InitViewBindingContainer(this, _UFCard,  this.Model.CalculationFee, "CalculationFee", "", null, 1, "费用计算");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(200,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID0", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","3a6d58a1-db6f-4eae-ab32-ec7b8aa54970","34511a25-9f32-410f-9472-7a3bab475404");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID0, "0");		


				this.ID0 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID0", "False", "False", "True", "Left", 7, 60, 0, 100, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID0","19.0","3a6d58a1-db6f-4eae-ab32-ec7b8aa54970","ca04d5e6-788c-4e69-8e26-b92646c205b2",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID0, "False", "ID", this.Model.CalculationFee, this.Model.CalculationFee.FieldID, "CalculationFee");
	
		
			UIControlBuilder.BuilderUFControl(this.ID0, "1");		
		 

				this.lblSysVersion0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion0", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","59701f91-9728-4fe8-b3e8-6b1af8a04eb7","01028055-7f7c-4fb6-8e8e-8df725567d4b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion0, "2");		


				this.SysVersion0 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion0", "True", "False", "True", "Left", 7, 60, 0, 100, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion0","19.0","59701f91-9728-4fe8-b3e8-6b1af8a04eb7","d11533b9-448f-4b8f-bf44-c45b1294fb9f",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion0, "False", "SysVersion", this.Model.CalculationFee, this.Model.CalculationFee.FieldSysVersion, "CalculationFee");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion0, "3");		
		 

				this.lblDeliveryFactory0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDeliveryFactory0", "", "True", "True", "Right", 60, 20, 0, 0, 1, 1, "100","9a63b8e4-d4ea-497c-bf1b-27ea10cb9e6e","0d203aed-c5ae-4e4b-b53f-1c6e29f6c482");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDeliveryFactory0, "4");		


		        this.DeliveryFactory0 = UIControlBuilder.BuilderDropDownList(_UFCard, "DeliveryFactory0", "UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum", true,  true, true, "Left", 2, 60, 0, 120, 20, 2, 0, 1, 1, "100",true,false,"lblDeliveryFactory0","9a63b8e4-d4ea-497c-bf1b-27ea10cb9e6e","2a25d34c-6963-4f60-821a-4a1e5da6dea0");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DeliveryFactory0, "False", "DeliveryFactory", this.Model.CalculationFee, this.Model.CalculationFee.FieldDeliveryFactory, "CalculationFee");
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum");
			EnumControlsMap.Add(this.DeliveryFactory0, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DeliveryFactory0, "5");		
		 

				this.lblSup0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSup0", "", "True", "True", "Right", 60, 20, 0, 1, 1, 1, "100","fde35994-6853-4aaa-869b-bab9b1a857cf","86cc09ed-16e3-4a7d-b74a-befbf0c6ccb4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSup0, "6");		


				this.Sup0 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Sup0",true,true, true,120, 20, 2, 1, 1, 1, "100","7",false,false,true,"lblSup0","fde35994-6853-4aaa-869b-bab9b1a857cf","ec961528-c70c-4c62-be43-c5af470e6102");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Sup0, "False", "Sup", this.Model.CalculationFee, this.Model.CalculationFee.FieldSup, "CalculationFee");
			UIControlBuilder.SetReferenceControlRefInfo(this.Sup0,"ea01ca72-c3a4-4563-b9b9-d47c720f051c", 580,408, "Name","Code","ID", this.Model.CalculationFee.FieldSup_Code,this.Model.CalculationFee.FieldSup_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Sup0,"Sup0",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","Category_Name",""),new ReferenceOutputParam("","Territory_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Sup0, "7");		
		 

				this.lblNumberOfTrucks0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblNumberOfTrucks0", "", "True", "True", "Right", 60, 20, 8, 2, 1, 1, "100","efcd952b-712f-4b16-b24d-3c938286a0ad","41591ff7-2740-4dc6-b336-0c5caa112b8e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblNumberOfTrucks0, "10");		


				this.NumberOfTrucks0 = UIControlBuilder.BuilderNumberControl(_UFCard, "NumberOfTrucks0", "True", "True", "True", "Left", 2, 60, 0, 120, 20, 10, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblNumberOfTrucks0","10.0","efcd952b-712f-4b16-b24d-3c938286a0ad","874c9fd6-d32e-4546-88fb-97304b28026b",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.NumberOfTrucks0, "False", "NumberOfTrucks", this.Model.CalculationFee, this.Model.CalculationFee.FieldNumberOfTrucks, "CalculationFee");
	
		
			UIControlBuilder.BuilderUFControl(this.NumberOfTrucks0, "11");		
		 

				this.lblShipDate0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblShipDate0", "", "True", "True", "Right", 60, 20, 8, 1, 1, 1, "100","62d2a081-6372-44bc-b3c4-33a521bb5ace","610fad03-dfc1-4c34-836d-8d60439360fd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblShipDate0, "12");		


				this.ShipDate0 = UIControlBuilder.BuilderDatePicker(_UFCard, "ShipDate0", true, true, true, "Date","Left", 3, 60, 0, 120, 20, 10, 1, 1, 1, "100",true,false,"lblShipDate0","62d2a081-6372-44bc-b3c4-33a521bb5ace","5c337b73-8c22-470b-8ab0-c1ca8e84a723");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ShipDate0, "False", "ShipDate", this.Model.CalculationFee, this.Model.CalculationFee.FieldShipDate, "CalculationFee");


		
			UIControlBuilder.BuilderUFControl(this.ShipDate0, "13");		
		 

				this.lblContain0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblContain0", "", "True", "True", "Right", 60, 20, 0, 2, 1, 1, "100","0b4d7327-65d9-4566-83df-bd69d7f147fa","b3101e8a-1a77-49b9-a8e9-da4dc942eab4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblContain0, "14");		


				this.Contain0 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "Contain0", true, true, "Left", 60, 0, 120, 20, 2, 2, 1, 1, "100",false,"lblContain0","0b4d7327-65d9-4566-83df-bd69d7f147fa","eac6b968-9167-46ee-bc44-6de5a8b0ede2");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Contain0, "False", "Contain", this.Model.CalculationFee, this.Model.CalculationFee.FieldContain, "CalculationFee");
		

		
			UIControlBuilder.BuilderUFControl(this.Contain0, "15");		
		 

				this.lblPricingMethod0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblPricingMethod0", "", "True", "True", "Right", 60, 20, 8, 0, 1, 1, "100","2f6df6c7-be67-4d30-81a1-9cb4456dc72d","f23346da-2dab-4007-9c7d-502498ba7c70");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPricingMethod0, "16");		


		        this.PricingMethod0 = UIControlBuilder.BuilderDropDownList(_UFCard, "PricingMethod0", "UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum", true,  true, true, "Left", 2, 60, 0, 120, 20, 10, 0, 1, 1, "100",true,false,"lblPricingMethod0","2f6df6c7-be67-4d30-81a1-9cb4456dc72d","92bf7f30-9501-49a6-96b8-2f0f9e14a754");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.PricingMethod0, "False", "PricingMethod", this.Model.CalculationFee, this.Model.CalculationFee.FieldPricingMethod, "CalculationFee");
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum");
			EnumControlsMap.Add(this.PricingMethod0, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.PricingMethod0, "17");		
		 

				this.Query0 = UIControlBuilder.BuilderUFButton(_UFCard, true, "Query0", true, true, 120, 20, 14, 2, 1, 1, "100","", this.Model.ElementID,"Query",false,"9b9a8cb6-9272-4bdc-9163-375c5b790a49","9b9a8cb6-9272-4bdc-9163-375c5b790a49","a8c897bb-5fad-47f4-a988-47a05637a1a9");
	

		
			UIControlBuilder.BuilderUFControl(this.Query0, "18");		


				this.lblSetLocation966 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSetLocation966", "", "True", "True", "Right", 60, 20, 4, 1, 1, 1, "100","4c1d55a7-ed0e-4ce3-85e5-57c0d78a65d9","32bf9579-a6c7-4ca1-852a-dd9dd75747fe");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSetLocation966, "19");		


				this.SetLocation966 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"SetLocation966",true,true, true,200, 20, 6, 1, 1, 1, "100","20",false,false,true,"lblSetLocation966","4c1d55a7-ed0e-4ce3-85e5-57c0d78a65d9","5b7b304e-72e2-4602-b047-41b825d0aded");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SetLocation966, "False", "SetLocation", this.Model.CalculationFee, this.Model.CalculationFee.FieldSetLocation, "CalculationFee");
			UIControlBuilder.SetReferenceControlRefInfo(this.SetLocation966,"88867236-ed09-4ff4-b1a1-ac0225470b39", 580,408, "Address_Name","Address_Code","ID", null,null);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.SetLocation966,"SetLocation966",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","DeliveryFactory",""),new ReferenceOutputParam("","Address_FormatAddress",""),new ReferenceOutputParam("","PricingMethod",""),new ReferenceOutputParam("","DeliveryPickup",""),new ReferenceOutputParam("","DeliveryCharges",""),new ReferenceOutputParam("","FreePickup",""),new ReferenceOutputParam("","FreeDelivery",""),new ReferenceOutputParam("","Address_ID",""),new ReferenceOutputParam("","Address_Code",""),new ReferenceOutputParam("","Address_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.SetLocation966, "20");		
		 

				this.lblProvince0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblProvince0", "", "False", "True", "Right", 60, 20, 0, 0, 1, 1, "100","e1b76148-d0ee-4eb8-965d-affa97c261c8","04999811-e8ab-4210-88fa-cff8cd2eb935");


								

		
			UIControlBuilder.BuilderUFControl(this.lblProvince0, "21");		


				this.Province0 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Province0",true,false, true,200, 20, 0, 0, 1, 1, "100","22",false,false,true,"lblProvince0","e1b76148-d0ee-4eb8-965d-affa97c261c8","d2e4b6d4-7437-4cee-8310-2c2054359427");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Province0, "False", "Province", this.Model.CalculationFee, this.Model.CalculationFee.FieldProvince, "CalculationFee");
			UIControlBuilder.SetReferenceControlRefInfo(this.Province0,"", 580,408, "","","", null,null);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
				

		
			UIControlBuilder.BuilderUFControl(this.Province0, "22");		
		 

				this.lblCity_Name1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCity_Name1", "", "False", "True", "Right", 60, 20, 0, 0, 1, 1, "100","ab466921-c312-4e5a-8d75-81dfac1ac218","2c652604-d81e-4ab5-96f2-6acf2940fbb0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCity_Name1, "23");		


				this.City_Name1 = UIControlBuilder.BuilderTextBox(_UFCard, "City_Name1", "True", "False", "True", "False", "Left", 0, 60, 0, 200, 20, 0, 0, 1, 1, "True", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCity_Name1","","50","ab466921-c312-4e5a-8d75-81dfac1ac218","1d1876fe-874e-4311-a9fa-082278774384");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.City_Name1, "False", "City_Name", this.Model.CalculationFee, this.Model.CalculationFee.FieldCity_Name, "CalculationFee");


		
			UIControlBuilder.BuilderUFControl(this.City_Name1, "24");		
		 

				this.lblCounty_Name0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCounty_Name0", "", "False", "True", "Right", 60, 20, 0, 0, 1, 1, "100","f5fa7a98-732d-4f8a-b93a-a7cddd03690b","9aea1409-560b-47ab-86ff-5205eda3d00a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCounty_Name0, "25");		


				this.County_Name0 = UIControlBuilder.BuilderTextBox(_UFCard, "County_Name0", "True", "False", "True", "False", "Left", 0, 60, 0, 200, 20, 0, 0, 1, 1, "True", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCounty_Name0","","50","f5fa7a98-732d-4f8a-b93a-a7cddd03690b","ac0b0479-5b83-446c-a517-3b7fe8125aaf");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.County_Name0, "False", "County_Name", this.Model.CalculationFee, this.Model.CalculationFee.FieldCounty_Name, "CalculationFee");


		
			UIControlBuilder.BuilderUFControl(this.County_Name0, "26");		
		 

				this.lblDescriLocation0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDescriLocation0", "", "False", "True", "Right", 60, 20, 0, 0, 1, 1, "100","22b279e0-3df4-4f8b-bac0-20a19846dbd3","735d82f1-88b6-4bf4-807f-316a545992bd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDescriLocation0, "27");		


				this.DescriLocation0 = UIControlBuilder.BuilderTextBox(_UFCard, "DescriLocation0", "True", "False", "True", "False", "Left", 0, 60, 0, 200, 20, 0, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblDescriLocation0","","50","22b279e0-3df4-4f8b-bac0-20a19846dbd3","b24c8035-61fe-404f-8752-c3678bb974d6");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DescriLocation0, "False", "DescriLocation", this.Model.CalculationFee, this.Model.CalculationFee.FieldDescriLocation, "CalculationFee");


		
			UIControlBuilder.BuilderUFControl(this.DescriLocation0, "28");		
		 

				this.lblAddress257 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAddress257", "", "True", "True", "Right", 60, 20, 4, 0, 1, 1, "100","208fc44d-9ad6-4a74-8282-40d94b86de94","92b08249-2048-4b7c-ad01-c3fd6a34e8ed");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAddress257, "29");		


				this.Address257 = UIControlBuilder.BuilderTextBox(_UFCard, "Address257", "True", "True", "True", "False", "Left", 0, 60, 0, 200, 20, 6, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblAddress257","","50","208fc44d-9ad6-4a74-8282-40d94b86de94","a1b5115d-ba8c-443c-b26a-528e80c1d49a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Address257, "False", "Address", this.Model.CalculationFee, this.Model.CalculationFee.FieldAddress, "CalculationFee");


		
			UIControlBuilder.BuilderUFControl(this.Address257, "30");		
		 


								
			this.Sup0.IsMultiOrg  = false ;
			this.lblSup0.SetMultiOrgInfo(this.Sup0,false);
			
											
			this.SetLocation966.IsMultiOrg  = false ;
			this.lblSetLocation966.SetMultiOrgInfo(this.SetLocation966,false);
			
		
			this.Province0.IsMultiOrg  = false ;
			this.lblProvince0.SetMultiOrgInfo(this.Province0,false);
			
								

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				

				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,false,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 950, 250, 0, 2, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.CalculationFee_CalculationFeeLine, "CalculationFee_CalculationFeeLine", "", null, 20, "费用计算.Misc.费用计算行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID1","NumberColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","6e4272e6-5793-4b83-9af2-78263069f138","6e4272e6-5793-4b83-9af2-78263069f138","50730d68-44d9-490c-a29c-4e2c8d7c0a36");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion1","NumberColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","0a0e1876-e9dc-4153-9511-a2f7d9a43c5b","0a0e1876-e9dc-4153-9511-a2f7d9a43c5b","07641c0c-eb85-469b-9f0d-46d77bf96253");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RealDeliveryFactory0","DropDownListColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["RealDeliveryFactory"]/*RealDeliveryFactory*/,"RealDeliveryFactory", false, true, true, false, false, true, 2, 100, "10.0",true, false,"-1","ac285e9f-011e-4c05-b126-1102a6a1dbc3","ac285e9f-011e-4c05-b126-1102a6a1dbc3","48f915a0-c26f-4587-8a18-23c4b7e583be");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.DeliveryFactoryEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DocType0","DropDownListColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["DocType"]/*DocType*/,"DocType", false, true, false, false, false, true, 2, 100, "10.0",true, false,"0","97818bdc-3129-4e05-b259-35512135fe83","97818bdc-3129-4e05-b259-35512135fe83","e192571e-0b0c-43a7-a274-4de60a5f5649");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.DocTypeEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DocNo0","TextBoxColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["DocNo"]/*DocNo*/,"DocNo", false, true, false, false, false, true, 0, 100, "50",true, false,"","c0a25543-3afc-4917-81f3-31a5382bd3fb","c0a25543-3afc-4917-81f3-31a5382bd3fb","570b4f8a-8231-4d55-a10e-71eaf5564b15");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DocID0","NumberColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["DocID"]/*DocID*/,"DocID", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","703b696c-e785-4e7a-8026-7b90ece852e7","703b696c-e785-4e7a-8026-7b90ece852e7","fdee94da-47d0-4722-aafa-c917cd19383d");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"LineID0","NumberColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["LineID"]/*LineID*/,"LineID", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","c1d87e12-eeb8-44fe-a02b-1ec9f8731316","c1d87e12-eeb8-44fe-a02b-1ec9f8731316","fa12bc2e-03f0-4e79-9ba2-94a57e57e4e2");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Item0","ReferenceColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["Item"]/*Item*/,"Item", false, true, false, false, false, true, 7, 100, "19.0",true, false,"","c751a0b7-fe86-4103-961b-334c927ed5d3","c751a0b7-fe86-4103-961b-334c927ed5d3","ab2996ce-a9da-474f-80d5-c5783d74d90f");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.CalculationFee_CalculationFeeLine.FieldItem_Code/*Item_Code*/, this.Model.CalculationFee_CalculationFeeLine.FieldItem_Name/*Item_Name*/, "beedebc3-5398-46b5-a237-5a3a4d13ad4f"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "ab2996ce-a9da-474f-80d5-c5783d74d90f";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Qty0","NumberColumnModel", "", 2,this.Model.CalculationFee_CalculationFeeLine.Fields["Qty"]/*Qty*/,"Qty", false, true, false, false, false, true, 11, 100, "53.0",true, false,"0","3d2fe207-ba1c-432b-ab3c-643d3a313303","3d2fe207-ba1c-432b-ab3c-643d3a313303","ba709ced-67b7-4aed-b6f5-07ce51c435a9");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SalesUom0","ReferenceColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["SalesUom"]/*SalesUom*/,"SalesUom", false, true, false, false, false, true, 7, 100, "19.0",true, false,"","97f74019-6b18-4a8f-a5cd-654ea7307633","97f74019-6b18-4a8f-a5cd-654ea7307633","2bed2686-bf5d-41ee-a8de-5301a7ab6e0e");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.CalculationFee_CalculationFeeLine.FieldSalesUom_Code/*SalesUom_Code*/, this.Model.CalculationFee_CalculationFeeLine.FieldSalesUom_Name/*SalesUom_Name*/, "2cb04e9c-44df-44e8-b518-f1ce0ba1e2cd"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "2bed2686-bf5d-41ee-a8de-5301a7ab6e0e";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							



						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RealPricingMethod0","DropDownListColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["RealPricingMethod"]/*RealPricingMethod*/,"RealPricingMethod", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","da14e749-0408-44b7-8304-d863947e2719","da14e749-0408-44b7-8304-d863947e2719","4ce19d09-5867-4cef-b603-8b08aaffcff6");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.CustLogisticsBE.PricingMethodEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"IBulk0","NumberColumnModel", "", 2,this.Model.CalculationFee_CalculationFeeLine.Fields["IBulk"]/*IBulk*/,"IBulk", false, true, false, false, false, true, 11, 100, "53.0",true, false,"0","494b0f6c-3b88-4a05-b9d0-80f6b4f1a6ae","494b0f6c-3b88-4a05-b9d0-80f6b4f1a6ae","d6587a37-88ec-484d-a22a-ac3160508b1a");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"BulkUom0","ReferenceColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["BulkUom"]/*BulkUom*/,"BulkUom", false, true, false, false, false, true, 7, 100, "19.0",true, false,"","e99856a8-a541-45b6-840b-f032eaedc50e","e99856a8-a541-45b6-840b-f032eaedc50e","d8173e8b-5d7a-432b-baa7-438e7a2adb1a");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.CalculationFee_CalculationFeeLine.FieldBulkUom_Code/*BulkUom_Code*/, this.Model.CalculationFee_CalculationFeeLine.FieldBulkUom_Name/*BulkUom_Name*/, "2cb04e9c-44df-44e8-b518-f1ce0ba1e2cd"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "d8173e8b-5d7a-432b-baa7-438e7a2adb1a";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							



						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Weight0","NumberColumnModel", "", 2,this.Model.CalculationFee_CalculationFeeLine.Fields["Weight"]/*Weight*/,"Weight", false, true, false, false, false, true, 11, 100, "53.0",true, false,"0","1bc96e84-8b11-4c53-b6ce-999cd0e08a3e","1bc96e84-8b11-4c53-b6ce-999cd0e08a3e","d482b611-ec3a-4049-979e-b8b7b052be6e");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"WeightUom0","ReferenceColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["WeightUom"]/*WeightUom*/,"WeightUom", false, true, false, false, false, true, 7, 100, "19.0",true, false,"","42dacd6b-0edb-4bbd-8a5d-d1b750f168c0","42dacd6b-0edb-4bbd-8a5d-d1b750f168c0","4467ecdf-7a48-435f-b289-9995c1dcd834");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.CalculationFee_CalculationFeeLine.FieldWeightUom_Code/*WeightUom_Code*/, this.Model.CalculationFee_CalculationFeeLine.FieldWeightUom_Name/*WeightUom_Name*/, "2cb04e9c-44df-44e8-b518-f1ce0ba1e2cd"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "4467ecdf-7a48-435f-b289-9995c1dcd834";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							



						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PricingQty0","NumberColumnModel", "", 2,this.Model.CalculationFee_CalculationFeeLine.Fields["PricingQty"]/*PricingQty*/,"PricingQty", false, true, false, false, false, true, 11, 100, "53.0",true, false,"0","91d40757-eb38-492f-b65f-e7ccbc980cea","91d40757-eb38-492f-b65f-e7ccbc980cea","34309dab-e977-4b0c-94c5-3055a01296ed");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PricingUom0","ReferenceColumnModel", "", 0,this.Model.CalculationFee_CalculationFeeLine.Fields["PricingUom"]/*PricingUom*/,"PricingUom", false, true, false, false, false, true, 7, 100, "19.0",true, false,"","b749cece-3955-4c2a-8f81-7165bc199c2f","b749cece-3955-4c2a-8f81-7165bc199c2f","c503a53c-9dc0-49fd-a066-2a8b215751ca");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.CalculationFee_CalculationFeeLine.FieldPricingUom_Code/*PricingUom_Code*/, this.Model.CalculationFee_CalculationFeeLine.FieldPricingUom_Name/*PricingUom_Name*/, "2cb04e9c-44df-44e8-b518-f1ce0ba1e2cd"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "c503a53c-9dc0-49fd-a066-2a8b215751ca";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							



						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",false,"none", true, true, "0","794bd189-a0c4-42f0-986b-60d75d60543b","74e432ee-ba7c-4357-b6e6-746f6fb9f510");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 950, 80, 0, 3, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 19, 3, 0, 5, 5, 10, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.CalculationFee_HuangdaoTotal, "CalculationFee_HuangdaoTotal", "", null, 1, "费用计算.Misc.黄岛合计");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 890, "Horizontal", "True", 890, 20, 0, 0, 19, 1, "100","0b81a91a-bfd8-42b2-aa63-1ad56fe5012c","0b81a91a-bfd8-42b2-aa63-1ad56fe5012c");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "0");		


				this.lblID2 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID2", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","794bd189-a0c4-42f0-986b-60d75d60543b","cca01e8a-edad-43b4-9024-2ee752a20011");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID2, "1");		


				this.ID2 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID2", "False", "False", "True", "Left", 7, 60, 0, 100, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID2","19.0","794bd189-a0c4-42f0-986b-60d75d60543b","66d6b781-9ac9-4768-a63b-65df1479bae6",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID2, "False", "ID", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldID, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.ID2, "2");		
		 

				this.lblSysVersion2 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion2", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","8b9d06c9-614c-44cf-9bca-d2992ba740c9","234b965c-58a7-4dcf-880d-ed8937232224");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion2, "3");		


				this.SysVersion2 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion2", "True", "False", "True", "Left", 7, 60, 0, 100, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion2","19.0","8b9d06c9-614c-44cf-9bca-d2992ba740c9","f0a52825-5a04-4f96-82a9-6f837201adf9",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion2, "False", "SysVersion", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldSysVersion, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion2, "4");		
		 

				this.lblTotalBulk0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblTotalBulk0", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","faa7cc7e-9ec6-4e0e-81f4-962be22a05c7","f6bd219e-3145-4b4b-b827-2cf0cd013988");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalBulk0, "5");		


				this.TotalBulk0 = UIControlBuilder.BuilderNumberControl(_UFCard, "TotalBulk0", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 2, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblTotalBulk0","53.0","faa7cc7e-9ec6-4e0e-81f4-962be22a05c7","9da00f2e-645b-49e2-9534-13078fb4771f",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalBulk0, "False", "TotalBulk", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldTotalBulk, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalBulk0, "6");		
		 

				this.lblTotalWeight0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblTotalWeight0", "", "True", "True", "Right", 100, 20, 0, 2, 1, 1, "100","5a71ddfc-64f4-47a7-9a7e-a81eb1d9e08a","f0179f81-da80-449f-bbb5-53e7d9844e2f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalWeight0, "7");		


				this.TotalWeight0 = UIControlBuilder.BuilderNumberControl(_UFCard, "TotalWeight0", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 2, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblTotalWeight0","53.0","5a71ddfc-64f4-47a7-9a7e-a81eb1d9e08a","f3843315-4310-496f-a8ef-9db1740e5b90",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalWeight0, "False", "TotalWeight", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldTotalWeight, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalWeight0, "8");		
		 

				this.lblRealBulk0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRealBulk0", "", "True", "True", "Right", 100, 20, 4, 1, 1, 1, "100","a1c2302c-65a6-47b1-99e4-9c5959680c84","92b4b775-9e42-45f4-99d8-bbe314268125");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRealBulk0, "9");		


				this.RealBulk0 = UIControlBuilder.BuilderNumberControl(_UFCard, "RealBulk0", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 6, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblRealBulk0","53.0","a1c2302c-65a6-47b1-99e4-9c5959680c84","2e7cb09b-94c0-42e5-8a89-ec6da5e7b063",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RealBulk0, "False", "RealBulk", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldRealBulk, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.RealBulk0, "10");		
		 

				this.lblRealWeight0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRealWeight0", "", "True", "True", "Right", 100, 20, 4, 2, 1, 1, "100","bb29cfec-9622-451c-af58-5917114ae11a","d21f5ce3-5056-40ea-807b-3fcb1c073f1b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRealWeight0, "11");		


				this.RealWeight0 = UIControlBuilder.BuilderNumberControl(_UFCard, "RealWeight0", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 6, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblRealWeight0","53.0","bb29cfec-9622-451c-af58-5917114ae11a","a2052b9f-4ddd-428b-b364-4426814b4a83",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RealWeight0, "False", "RealWeight", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldRealWeight, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.RealWeight0, "12");		
		 

				this.lblPickupFee0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblPickupFee0", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","0aa4de95-c9d8-4d3c-b40f-12efdcac916a","30cecdf0-a9e1-4a5f-85e3-28d45d61667b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPickupFee0, "13");		


				this.PickupFee0 = UIControlBuilder.BuilderNumberControl(_UFCard, "PickupFee0", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 10, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblPickupFee0","53.0","0aa4de95-c9d8-4d3c-b40f-12efdcac916a","102d3085-dcde-4233-9405-553809a8dac3",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.PickupFee0, "False", "PickupFee", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldPickupFee, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.PickupFee0, "14");		
		 

				this.lblDeliveryFee0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDeliveryFee0", "", "True", "True", "Right", 100, 20, 8, 2, 1, 1, "100","1c51151a-a6de-4c9a-a3da-c166bb076e85","fde0d1fb-1c89-4463-8cae-effa7243e9df");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDeliveryFee0, "15");		


				this.DeliveryFee0 = UIControlBuilder.BuilderNumberControl(_UFCard, "DeliveryFee0", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 10, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDeliveryFee0","53.0","1c51151a-a6de-4c9a-a3da-c166bb076e85","4d5da6c7-e819-4d89-80f7-a51c1d0dcfa3",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DeliveryFee0, "False", "DeliveryFee", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldDeliveryFee, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.DeliveryFee0, "16");		
		 

				this.lblDischargeFee295 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDischargeFee295", "", "True", "True", "Right", 100, 20, 12, 1, 1, 1, "100","35cb9043-a9ed-4e3d-bbe6-08be2b23eae0","6d22dfef-721b-4fae-bec6-fea18ab0415f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDischargeFee295, "17");		


				this.DischargeFee295 = UIControlBuilder.BuilderNumberControl(_UFCard, "DischargeFee295", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 14, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDischargeFee295","53.0","35cb9043-a9ed-4e3d-bbe6-08be2b23eae0","132ca908-3cc5-4768-96ed-086ec5494c62",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DischargeFee295, "False", "DischargeFee", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldDischargeFee, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.DischargeFee295, "18");		
		 

				this.lblOtherFee129 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblOtherFee129", "", "True", "True", "Right", 100, 20, 12, 2, 1, 1, "100","5994ec3b-f4ec-42e7-b86c-b9de42a73aca","28f0076d-a0b7-42bb-b4b0-5006a43e43ad");


								

		
			UIControlBuilder.BuilderUFControl(this.lblOtherFee129, "19");		


				this.OtherFee129 = UIControlBuilder.BuilderNumberControl(_UFCard, "OtherFee129", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 14, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblOtherFee129","53.0","5994ec3b-f4ec-42e7-b86c-b9de42a73aca","1a3ddf8c-5ed5-4971-a8d0-5eb218283405",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.OtherFee129, "False", "OtherFee", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldOtherFee, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.OtherFee129, "20");		
		 

				this.lblTotalFreight192 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblTotalFreight192", "", "True", "True", "Right", 100, 20, 16, 1, 1, 1, "100","3657b0ef-e7a4-45f5-a486-4a05d3631786","1213abc1-5071-4b26-bac3-1aef16a980a0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalFreight192, "21");		


				this.TotalFreight192 = UIControlBuilder.BuilderNumberControl(_UFCard, "TotalFreight192", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 18, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblTotalFreight192","53.0","3657b0ef-e7a4-45f5-a486-4a05d3631786","818bb2db-70dc-4931-9b34-7b93ef2f7258",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalFreight192, "False", "TotalFreight", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldTotalFreight, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalFreight192, "22");		
		 

				this.lblRealFreight179 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRealFreight179", "", "True", "True", "Right", 100, 20, 16, 2, 1, 1, "100","2fda720e-2cb7-4137-9513-6ec89220309d","42ca30b2-a3a6-4e3f-b00f-70365568cee6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRealFreight179, "23");		


				this.RealFreight179 = UIControlBuilder.BuilderNumberControl(_UFCard, "RealFreight179", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 18, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblRealFreight179","53.0","2fda720e-2cb7-4137-9513-6ec89220309d","52832e40-d1d8-4467-9c67-133ca6262758",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RealFreight179, "False", "RealFreight", this.Model.CalculationFee_HuangdaoTotal, this.Model.CalculationFee_HuangdaoTotal.FieldRealFreight, "CalculationFee_HuangdaoTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.RealFreight179, "24");		
		 


																									

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "0","d29e337a-8c1c-47a5-a7b2-7bf142365551","caf87756-331c-41f0-bbd6-87e9e1a73221");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 950, 80, 0, 4, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 19, 3, 0, 5, 5, 10, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.CalculationFee_ChenyangTotal, "CalculationFee_ChenyangTotal", "", null, 1, "费用计算.Misc.城阳合计");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Line1 = UIControlBuilder.BuilderUFLine(_UFCard, "Line1", 890, "Horizontal", "True", 890, 20, 0, 0, 19, 1, "100","a947fd38-734b-4863-8525-ed09ff190234","a947fd38-734b-4863-8525-ed09ff190234");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "0");		


				this.lblID3 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID3", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","d29e337a-8c1c-47a5-a7b2-7bf142365551","d9535931-3c9a-4304-b21d-53a1daca362e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID3, "1");		


				this.ID3 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID3", "False", "False", "True", "Left", 7, 60, 0, 60, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID3","19.0","d29e337a-8c1c-47a5-a7b2-7bf142365551","9977d2d0-e5ea-470a-9c55-93599a492aee",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID3, "False", "ID", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldID, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.ID3, "2");		
		 

				this.lblSysVersion3 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion3", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","2c2b7f10-bc75-4767-9500-4e438534cd4b","2f664da3-7a61-4104-b0a3-6cc9464a3bfd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion3, "3");		


				this.SysVersion3 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion3", "True", "False", "True", "Left", 7, 60, 0, 60, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion3","19.0","2c2b7f10-bc75-4767-9500-4e438534cd4b","c3abd2d5-f71e-479f-b51d-7032af965e45",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion3, "False", "SysVersion", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldSysVersion, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion3, "4");		
		 

				this.lblTotalBulk2 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblTotalBulk2", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","eb59303e-83d8-4f1f-96a7-0728a8166d74","004a005b-35ac-4178-b340-65e4ee662bac");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalBulk2, "5");		


				this.TotalBulk2 = UIControlBuilder.BuilderNumberControl(_UFCard, "TotalBulk2", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 2, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblTotalBulk2","53.0","eb59303e-83d8-4f1f-96a7-0728a8166d74","04c71ed8-8e46-4b5c-81e7-ea8be8facbf8",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalBulk2, "False", "TotalBulk", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldTotalBulk, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalBulk2, "6");		
		 

				this.lblTotalWeight1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblTotalWeight1", "", "True", "True", "Right", 100, 20, 0, 2, 1, 1, "100","77069d4c-cbbe-4e16-9f58-fafe5a01ce3e","604150b1-d050-47dc-a798-13fefa29f5cc");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalWeight1, "7");		


				this.TotalWeight1 = UIControlBuilder.BuilderNumberControl(_UFCard, "TotalWeight1", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 2, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblTotalWeight1","53.0","77069d4c-cbbe-4e16-9f58-fafe5a01ce3e","50058ead-7420-4c14-84c0-08d6a182da82",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalWeight1, "False", "TotalWeight", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldTotalWeight, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalWeight1, "8");		
		 

				this.lblRealBulk1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRealBulk1", "", "True", "True", "Right", 100, 20, 4, 1, 1, 1, "100","70a83b06-b4d6-4153-a83d-fd5336abe235","0f8a92d4-ee68-4271-8934-6dda0ed7cf42");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRealBulk1, "9");		


				this.RealBulk1 = UIControlBuilder.BuilderNumberControl(_UFCard, "RealBulk1", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 6, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblRealBulk1","53.0","70a83b06-b4d6-4153-a83d-fd5336abe235","e7dfa188-39cb-46a1-864e-a96462f0f6e8",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RealBulk1, "False", "RealBulk", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldRealBulk, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.RealBulk1, "10");		
		 

				this.lblRealWeight1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRealWeight1", "", "True", "True", "Right", 100, 20, 4, 2, 1, 1, "100","f6b5f60f-77c5-4024-8fe1-90dc1502cb58","9cc99cea-c9f4-407c-a860-0da5b59de5df");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRealWeight1, "11");		


				this.RealWeight1 = UIControlBuilder.BuilderNumberControl(_UFCard, "RealWeight1", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 6, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblRealWeight1","53.0","f6b5f60f-77c5-4024-8fe1-90dc1502cb58","d3447e53-d043-452d-a752-5dfd15994ee3",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RealWeight1, "False", "RealWeight", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldRealWeight, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.RealWeight1, "12");		
		 

				this.lblPickupFee1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblPickupFee1", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","7c1a72c6-622b-4d4d-97ef-006d5f029483","32ea3dcf-b0f8-450d-9f40-140be8941bfa");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPickupFee1, "13");		


				this.PickupFee1 = UIControlBuilder.BuilderNumberControl(_UFCard, "PickupFee1", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 10, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblPickupFee1","53.0","7c1a72c6-622b-4d4d-97ef-006d5f029483","b23fb3c6-f93a-43f3-95d4-d699402b78bc",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.PickupFee1, "False", "PickupFee", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldPickupFee, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.PickupFee1, "14");		
		 

				this.lblDeliveryFee1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDeliveryFee1", "", "True", "True", "Right", 100, 20, 8, 2, 1, 1, "100","3e25846d-ec9d-4832-9984-a6cd75e6cd44","97c69378-1433-47e3-b28d-27983726ddb7");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDeliveryFee1, "15");		


				this.DeliveryFee1 = UIControlBuilder.BuilderNumberControl(_UFCard, "DeliveryFee1", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 10, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDeliveryFee1","53.0","3e25846d-ec9d-4832-9984-a6cd75e6cd44","6626dd1f-8611-442e-ab79-96e649400560",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DeliveryFee1, "False", "DeliveryFee", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldDeliveryFee, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.DeliveryFee1, "16");		
		 

				this.lblDischargeFee296 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDischargeFee296", "", "True", "True", "Right", 100, 20, 12, 1, 1, 1, "100","92200600-8792-4a3a-8f46-b7d69a6ca2f3","61797958-d534-4606-8651-3984f068fac8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDischargeFee296, "17");		


				this.DischargeFee296 = UIControlBuilder.BuilderNumberControl(_UFCard, "DischargeFee296", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 14, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDischargeFee296","53.0","92200600-8792-4a3a-8f46-b7d69a6ca2f3","bdfdbdf5-af59-4a15-b93b-2dc7c85b3424",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DischargeFee296, "False", "DischargeFee", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldDischargeFee, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.DischargeFee296, "18");		
		 

				this.lblOtherFee130 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblOtherFee130", "", "True", "True", "Right", 100, 20, 12, 2, 1, 1, "100","187561b5-de86-4a3b-a76b-ab602694bab2","b2c70dad-9a6a-4dfc-b684-21e6929f5f3d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblOtherFee130, "19");		


				this.OtherFee130 = UIControlBuilder.BuilderNumberControl(_UFCard, "OtherFee130", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 14, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblOtherFee130","53.0","187561b5-de86-4a3b-a76b-ab602694bab2","5f748a0f-86e1-4963-9024-285b1914d59e",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.OtherFee130, "False", "OtherFee", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldOtherFee, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.OtherFee130, "20");		
		 

				this.lblTotalFreight193 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblTotalFreight193", "", "True", "True", "Right", 100, 20, 16, 1, 1, 1, "100","77361a10-b484-40c1-8dd7-105bb17ca5c9","01c5e9a0-c2f9-46db-b7b9-499743722d19");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalFreight193, "21");		


				this.TotalFreight193 = UIControlBuilder.BuilderNumberControl(_UFCard, "TotalFreight193", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 18, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblTotalFreight193","53.0","77361a10-b484-40c1-8dd7-105bb17ca5c9","6180676f-9706-4620-bc68-5dd1bbd8c40c",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalFreight193, "False", "TotalFreight", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldTotalFreight, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalFreight193, "22");		
		 

				this.lblRealFreight180 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRealFreight180", "", "True", "True", "Right", 100, 20, 16, 2, 1, 1, "100","8bff73b7-6b10-4621-b88d-15b9aee711ef","7a0c82ac-565d-49dc-8763-179a532db1cf");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRealFreight180, "23");		


				this.RealFreight180 = UIControlBuilder.BuilderNumberControl(_UFCard, "RealFreight180", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 18, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblRealFreight180","53.0","8bff73b7-6b10-4621-b88d-15b9aee711ef","8b2bb56b-05b4-4484-9bb9-0858adc148f8",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RealFreight180, "False", "RealFreight", this.Model.CalculationFee_ChenyangTotal, this.Model.CalculationFee_ChenyangTotal.FieldRealFreight, "CalculationFee_ChenyangTotal");
	
		
			UIControlBuilder.BuilderUFControl(this.RealFreight180, "24");		
		 


																									

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "0","e82c37ac-f17e-4bfb-99ff-7a5791e9c783","651bd1cf-c900-4d52-aca7-8a1c53e1cf4e");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 950, 60, 0, 5, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 15, 2, 0, 5, 5, 10, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.CalculationFee, "CalculationFee", "", null, 1, "费用计算");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(200,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Line2 = UIControlBuilder.BuilderUFLine(_UFCard, "Line2", 540, "Horizontal", "True", 540, 20, 0, 0, 12, 1, "100","031062f3-b342-4e33-b3c7-47015bf69e64","031062f3-b342-4e33-b3c7-47015bf69e64");
	

		
			UIControlBuilder.BuilderUFControl(this.Line2, "0");		


				this.lblTotalAmount0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblTotalAmount0", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","e82c37ac-f17e-4bfb-99ff-7a5791e9c783","f0799c66-0a68-470c-9654-9e11ddb79172");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalAmount0, "1");		


				this.TotalAmount0 = UIControlBuilder.BuilderNumberControl(_UFCard, "TotalAmount0", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 2, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblTotalAmount0","53.0","e82c37ac-f17e-4bfb-99ff-7a5791e9c783","7d6b2c5b-b869-4abf-b826-5a1a27d01c26",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalAmount0, "False", "TotalAmount", this.Model.CalculationFee, this.Model.CalculationFee.FieldTotalAmount, "CalculationFee");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalAmount0, "2");		
		 

				this.lblUintPrice0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblUintPrice0", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","0e37bed4-9c8c-4dfd-8d76-50f908e252da","ee3c355f-725a-44ec-a0af-1a564ddb04c5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblUintPrice0, "5");		


				this.UintPrice0 = UIControlBuilder.BuilderNumberControl(_UFCard, "UintPrice0", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 10, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblUintPrice0","53.0","0e37bed4-9c8c-4dfd-8d76-50f908e252da","3654504c-c4fb-41ca-97c1-97f2867ee28d",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.UintPrice0, "False", "UintPrice", this.Model.CalculationFee, this.Model.CalculationFee.FieldUintPrice, "CalculationFee");
	
		
			UIControlBuilder.BuilderUFControl(this.UintPrice0, "6");		
		 

				this.lblRemark225 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRemark225", "", "True", "True", "Right", 100, 20, 12, 0, 1, 1, "100","6f2040d8-c2ff-47b9-b283-951326c3927b","02993999-daa5-40e9-835f-99abc7585853");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRemark225, "7");		


				this.Remark225 = UIControlBuilder.BuilderTextBox(_UFCard, "Remark225", "True", "True", "True", "True", "Left", 0, 60, 0, 200, 45, 14, 0, 1, 2, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblRemark225","","50","6f2040d8-c2ff-47b9-b283-951326c3927b","959b2f19-ccc8-4e16-bf6b-baea1e4dd9f3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Remark225, "False", "Remark", this.Model.CalculationFee, this.Model.CalculationFee.FieldRemark, "CalculationFee");


		
			UIControlBuilder.BuilderUFControl(this.Remark225, "8");		
		 

				this.lblRealAmount1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRealAmount1", "", "True", "True", "Right", 100, 20, 4, 1, 1, 1, "100","c59f375f-b5a0-41de-9cd1-bdc8901afd9e","a6c29e97-c501-4f29-bf90-05f90c26bc0f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRealAmount1, "9");		


				this.RealAmount1 = UIControlBuilder.BuilderNumberControl(_UFCard, "RealAmount1", "True", "True", "True", "Left", 11, 60, 0, 60, 20, 6, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblRealAmount1","53.0","c59f375f-b5a0-41de-9cd1-bdc8901afd9e","9f5324f8-8f91-4658-a86b-e4a12385c5ff",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RealAmount1, "False", "RealAmount", this.Model.CalculationFee, this.Model.CalculationFee.FieldRealAmount, "CalculationFee");
	
		
			UIControlBuilder.BuilderUFControl(this.RealAmount1, "10");		
		 


									

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card5(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card5",false,"none", true, true, "0","","b84e7297-2cb3-4022-94d1-232ff274634d");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 950, 25, 0, 6, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 13, 1, 0, 5, 10, 5, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card5 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Complex0 = UIControlBuilder.BuilderUFButton(_UFCard, true, "Complex0", true, true, 100, 20, 8, 0, 1, 1, "100","", this.Model.ElementID,"Complex",false,"c585d8d4-81b9-4a50-816e-24fc0a3dea96","c585d8d4-81b9-4a50-816e-24fc0a3dea96","6fc56487-43e9-4727-9316-439645786827");
	

		
			UIControlBuilder.BuilderUFControl(this.Complex0, "0");		


				this.ManualCostsharing0 = UIControlBuilder.BuilderUFButton(_UFCard, true, "ManualCostsharing0", true, true, 100, 20, 10, 0, 1, 1, "100","", this.Model.ElementID,"ManualCostsharing",false,"e17d394f-ae47-4988-8357-1c4dbb63c62d","e17d394f-ae47-4988-8357-1c4dbb63c62d","ae771399-f5d8-453e-8045-d8a75e5e12dc");
	

		
			UIControlBuilder.BuilderUFControl(this.ManualCostsharing0, "1");		


				this.Costsharing0 = UIControlBuilder.BuilderUFButton(_UFCard, true, "Costsharing0", true, true, 100, 20, 12, 0, 1, 1, "100","", this.Model.ElementID,"Costsharing",false,"d82cf32e-334e-4647-9c3b-1569530b96fb","d82cf32e-334e-4647-9c3b-1569530b96fb","2c1b7e84-b588-4ca1-b11e-4fa550b79036");
	

		
			UIControlBuilder.BuilderUFControl(this.Costsharing0, "2");		


				this.SaveClick0 = UIControlBuilder.BuilderUFButton(_UFCard, true, "SaveClick0", true, true, 100, 20, 6, 0, 1, 1, "100","S", this.Model.ElementID,"SaveClick",false,"f39bbf7f-4ec5-4323-8204-ee10fee20f66","f39bbf7f-4ec5-4323-8204-ee10fee20f66","e9bf66d2-56b8-414b-86ee-59a33b37440e");
	

		
			UIControlBuilder.BuilderUFControl(this.SaveClick0, "3");		



				

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
