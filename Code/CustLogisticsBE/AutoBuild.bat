
echo reset IIS
echo iisreset

echo beging copy componet dll to portal and appserver

copy .\Entity\bin\Debug\UFIDA.U9.Cust.BLT.CustLogisticsBE.Deploy.dll  C:\yonyou\U9V60\Portal\ApplicationLib
copy .\Entity\bin\Debug\UFIDA.U9.Cust.BLT.CustLogisticsBE.Deploy.pdb  C:\yonyou\U9V60\Portal\ApplicationLib

copy .\Entity\bin\Debug\UFIDA.U9.Cust.BLT.CustLogisticsBE.dll  C:\yonyou\U9V60\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.BLT.CustLogisticsBE.pdb  C:\yonyou\U9V60\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.BLT.CustLogisticsBE.Deploy.dll  C:\yonyou\U9V60\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.Cust.BLT.CustLogisticsBE.Deploy.pdb  C:\yonyou\U9V60\Portal\ApplicationServer\Libs



echo begin run build component Script
echo DIR1: .\..\..\bulk\\Unconfiged\MetadataScript\
echo DIR2: .\..\..\bulk\\Unconfiged\DBScript\
echo .\..\..\..\..\..\Yonyou\UBFV60\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=123456;Data Source=DESKTOP-LQO9U6R;Initial Catalog=zydev;packet size=4096;Max Pool size=1500;persist security info=True" -NotDropDB -NotWriteLog -ExecuteDelete .\..\..\..\..\Code\U9demo\CustLogistics\bulk\\Unconfiged\MetadataScript\ .\..\..\..\..\Code\U9demo\CustLogistics\bulk\\Unconfiged\DBScript\

echo componet  buid end
pause

