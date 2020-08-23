
# 簡易活動報名系統

## really code first

<https://dotblogs.com.tw/supershowwei/2016/04/11/000015>

前一個專案使用 code first by database ，此次專案要真正的使用 code first，並且搭配相對應的標籤與使用 cmd 。

---

## 使用技術

* MVC5 / Code first / Razor / JS / SSMS

## 功能

1. 開啟一個Asp.net MVC專案
2. 寫一個新達2020/9/25活動報名系統(新增、修改、刪除)
  2.1需要欄位(手機、姓名、email 、活動項目(可多選)( AM10:00~AM11:00排球、AM11:00~PM12:00羽球、PM15:00~PM16:00自行車 …)
  2.2活動項目，須從資料庫來
  2.3所有欄位都必填(需檢查)
  2.4相同的手機，只能報名一次
  2.5報名完成，需要顯示 報名詳細資訊
  2.6列表 所有活動名稱、報名人數 及 詳細頁 報名人員、姓名、手機、報名時間
  2.6刪除需有確認提示視窗
  2.7列表根據三個欄位(姓名/手機(模糊查詢)、活動項目(含全部)(下拉) 進行查詢
  2.8查詢出來的列表，需有會 手機、姓名、email 、活動項目(用逗點區隔),報名時間  欄位
  2.9相關資料表
    * tblSignup報名資訊
      * cMobile,varchar(10)，手機 ,PK
      * cName,nvarchar(20)，姓名
      * cEmail,nvarchar(50)，Email
      * cCreateDT,datetime,報名時間(新增當下)
    * tblSignupItem 報名項目
      * cMobile varchar(10), 手機，,PK
      * cItemID,int, 項目ID，PK
    * tblActiveItem 活動項目
      * cItemID,int,pk，項目ID
      * cItemName, 活動項目名稱
      * cActiveDt,活動時間
  2.10參考畫面 根據上面提示，自行發想
3. 與資料庫聯繫，需使用EF codefirst
4. 建立專案，須將專案加入git版控
5. 須將網站，部屬至本機端IIS上

## 重點

## 步驟

1. 首先在專案內想建構 DAL 的地方
2. 右鍵新增項目 -> 資料 -> ADO.NET 實體資料模型
3. 選擇空的 Code First 模型
   * 此時 IDE 會幫忙添加以下資料
     * packages.config
     * SimplesSignupSystem.csproj
     * Web.config ★★ (連線資訊 connectionStrings) 等確定實體後才來更改連線方式 SQL Service 登入 ★★
     * SignupDB.cs ★★ (DbContext 設定檔) 處理連線資訊與關聯實體 DTO ★★
4. 編輯 DTO 資料表 Class 此處分為實體用途與其餘用途使用的 DTO

   > [EF 中,當某一個屬性視為 primary key 時，如果該屬性類別為 int，則生成資料庫時會自動變成自加序號，那如果不是 int 而是 Guid，那就必須你自己給值，或自己設定為自加序號。](https://charleslin74.pixnet.net/blog/post/458313893-%5Bc%23%5D-entity-framework%E4%B8%AD%E7%9A%84databasegenerated%E5%B1%AC%E6%80%A7)
   * PK 屬性 Guid 自加序號 [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   * PK 屬性 int 不自加序號 [DatabaseGenerated(DatabaseGeneratedOption.None)]
   * 此標籤代表 參數是透過計算而來 DB 不會實際儲存此值 [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

5. [建立完 DTO 與 DBContext 後，重點來了 ★★ 執行 db first cmd ★★](https://dotblogs.com.tw/supershowwei/2016/04/11/000015)
   * 套件管理器主控台輸入指令 `Enable-Migrations`。 此指令會幫忙驗證模型的結構


* packages.config

```XML
<package id="EntityFramework" version="6.2.0" targetFramework="net472" />
<package id="EntityFramework.zh-Hant" version="6.2.0" targetFramework="net472" />
```

* SimplesSignupSystem.csproj

```XML
<Reference Include="EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, processorArchitecture=MSIL">
  <HintPath>..\packages\EntityFramework.6.2.0\lib\net45\EntityFramework.dll</HintPath>
</Reference>
<Reference Include="EntityFramework.SqlServer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, processorArchitecture=MSIL">
  <HintPath>..\packages\EntityFramework.6.2.0\lib\net45\EntityFramework.SqlServer.dll</HintPath>
</Reference>
```

* Web.config

```XML
<configuration>
   <connectionStrings>
      <add name="SignupDB" connectionString="data source=(LocalDb)\MSSQLLocalDB;initial catalog=SimpleSignupSystem.DAL.SignupDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
   </connectionStrings>
</configuration>
```

## 參考

<https://dotblogs.com.tw/supershowwei/2016/04/11/000015>

<https://charleslin74.pixnet.net/blog/post/458313893-%5Bc%23%5D-entity-framework%E4%B8%AD%E7%9A%84databasegenerated%E5%B1%AC%E6%80%A7>

<https://www.google.com/search?q=DTO&oq=DTO&aqs=chrome.0.69i59j0l7.2231j0j4&sourceid=chrome&ie=UTF-8>

<https://stackoverflow.com/questions/31903342/error-2019-member-mapping-specified-is-not-valid-using-entity-framework-code-fi>

<https://hant-kb.kutu66.com/wpf/post_1510868>

<https://www.google.com/search?q=HashSet&oq=HashSet&aqs=chrome..69i57j0l7.111j0j4&sourceid=chrome&ie=UTF-8>

<https://www.cnblogs.com/firstdream/archive/2012/04/13/2445582.html>

<https://dotblogs.com.tw/wasichris/2014/08/23/146339>
