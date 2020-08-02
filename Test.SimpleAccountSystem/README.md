# 簡易帳號管理系統

1. 開啟一個 Asp.net MVC 專案
2. 寫一個帳號管理系統(新增、修改、刪除)
    * 使用者欄位(帳號、姓名、email、權限群組(可多選)(系統管理員、上槁者、稽核…) 、狀態 啟用 1 停用 0 )
    * 權限群組位值，須從資料庫來
    * 所有欄位都必填(需檢查)
    * 相同的帳號，只能註冊一次
    * 註冊完成，需提示會員新增完成
    * 新增、編輯、刪除需有確認提示視窗
    * 根據兩個欄位(姓名、權限群組)進行模糊查詢
    * 查詢出來的列表，需有會 帳號、姓名、email、權限群組(多，可用頓點分隔),狀態  欄位
    * 相關資料表
      * tblUser會員資訊
        * cAccount,varchar(20)，帳號 ,PK
        * cName,nvarchar(20)，姓名
        * cEmail,nvarchar(50)，Email
        * cCreateDT,datetime,註冊時間(新增當下)
        * cStatus,int,狀態(1.啟用、0.停用)
      * tblUserGroup 使用者權限
        * cAccount varchar(20),會員帳號，int,PK
        * cGroupID,int,權限群組編號，PK
      * tblGroup 權限清單
        * cGroupID,int,pk，興趣項目ID
        * cGroupName,興趣項目名稱
    * 參考畫面 根據上面提示，自行發想
3. 與資料庫聯繫，需使用EF codefirst
4. 建立專案，須將專案加入git版控
5. 須將網站，部屬至本機端IIS上

## 重點

* DataTable 動態型別，資料量大會爆
* 最好做 DTO (Class/Model)
* Model 驗證標籤
* 將多筆合併為一筆顯示

<https://dotblogs.com.tw/kevinya/2012/06/01/72553>

* EF CodeFirst
* IIS 發行
* LINQ Contains = SQL Like 模糊查詢

## 步驟

![alt](/Cinda.Test.SimpleAccountSystem/assets/img/mvcCSharp.png)

1. 首先是專案使用的語言，第一次作業時沒看清楚選擇了 VB，雖然大部分元件能共用，但編輯規則與一些細節差異還是蠻大的。(重點：C#是綠色的WWW_ICON，VB是藍色的)
2. 再來是.NET Core 與 .NET Framework 是不同的庫，用法也不太一樣，此處我們選擇舊.NET Framework Web 應用程式，因為.NET Core Web 是用注入方式起的 Console 專案需要的部分要額外引入，可能要實作的部分較多先不考慮。
3. 起完專案後首先設定 .gitignore <https://stackoverflow.com/questions/42725864/dotnet-mvc-5-gitignore>
4. 請你輸入檔名坑 - 只要把檔名輸入成 .gitignore. <https://blog.miniasp.com/post/2017/01/01/Create-gitignore-editorconfig-from-Windows-Explorer>