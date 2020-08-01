# 新人試驗

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

## DataTable 動態型別，資料量大會爆

## 最好做 DTO (Class/Model)

## Model 驗證標籤

## 將多筆合併為一筆顯示

<https://dotblogs.com.tw/kevinya/2012/06/01/72553>

## EF CodeFirst

## IIS 發行

## LINQ Contains = SQL Like 模糊查詢
