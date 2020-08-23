
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

1. 首先在專案內想建構 DAL 的地方，右鍵新增項目 -> 資料 -> ADO.NET 實體資料模型
2. 選擇

## 參考

<https://dotblogs.com.tw/supershowwei/2016/04/11/000015>

<https://charleslin74.pixnet.net/blog/post/458313893-%5Bc%23%5D-entity-framework%E4%B8%AD%E7%9A%84databasegenerated%E5%B1%AC%E6%80%A7>
