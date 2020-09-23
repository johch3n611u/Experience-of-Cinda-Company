# 研討會

## 目錄

[Topshelf & Quartz.Net](#1)

[Dapper ORM](#2)

[CAPTCHA 圖靈測試](#3)

[SASS / LESS](#4)

## Topshelf & Quartz.Net <a id="1"></a>

<https://dotblogs.com.tw/wasichris/2017/01/14/165637>

利用服務跑排程，一個排程一個服務(Service)，要利用容器才能啟用多個服務 ? (名稱不能一樣)

job / trigger / schedule (取代 Timer) - 有支援 .new core

補充 : 直接手動執行而不是透過服務執行排程

## Dapper ORM <a id="2"></a>

|比較|EF x Dapper 混用|EF|Dapper|
|-|-|-|-|
|操作性|:cupid:|:cupid:|-|
|效能|:cupid:|-|:cupid:|
|查詢精準度|:cupid:|-|:cupid:|
|可讀性|:cupid:|:cupid:|-|

> Dapper 用於查詢

搭配 AutoMapping 等 map 才會好用， Dapper 的罩門是關聯

<https://github.com/shps951023/Trace-Dapper.NET-Source-Code>

## CAPTCHA 圖靈測試 <a id="3"></a>

Google reCAPTCHA v2 , v3 費用 0

## SASS / LESS <a id="4"></a>

LESS 可由 js 轉為 css ， SASS 是由 Ruby 編寫需要編譯為 css ，但具有較多程式特性 e.g. 繼承...

<http://programmermagazine.github.io/201409/htm/focus2.html>

## CSharp 非同步程式 <a id="5"></a>

i/o、調用API、存取資料表 有效 (產能增加)

CPU (看硬體效能)無效 (效能不變)

Task Like void

await async 等待器消耗 100mb

非必要時少掛 async 關鍵字

> 調用時要排序不然跟同步沒啥兩樣

Task 很多寫法

危險性 Dead lock / 資料亂跳異常

Current 不為 null / 會卡執行序

> nodejs 非同步庫比 csharp 好懂 ?

不會起新執行序 ( 不是真正意義上的多工 )

configre await 死鎖原因及解法

asp.core 沒這問題

## Angular pipe regx <a id="6"></a>

ng 寶哥 套件 又見 可以快速建立裝飾器

## SSRS SQL Server Reporting Services <a id="7"></a>

伺服器端的報表產生系統 Gui 給工程師下 sql 做報表

似乎要錢

<http://www.blueshop.com.tw/board/FUM20041006161839LRJ/BRD20050809154645F57.html>

<https://ithelp.ithome.com.tw/articles/10181489>

資料集

還是需要工程師，會有一點學習成本，但是上手後產報表速度似乎比寫得快 ? ( 待參考 )

IIF nothing ( VB use )

Blob 二進位大型物件

XML

---

權限設定是個問題不知道有沒有，會造成任何人從 url 都可進入報表畫面。

可以克制 css 但是比較硬難改，直接編輯 xml，效能問題，但報表轉格式 download 方便，維護方便。report 方便

## Navicat Premium <a id="8"></a>

以單一的 GUI 資料庫管理套件，同時連線到不同類型的資料庫

## SQL 效能調校 <a id="9"></a>

### 查詢成本 執行計畫

### IN < EXISTS

### INSERT INTO (Table存在) < SELECT INTO (Table不存在) (通常直接備份時使用)

### Order by (無 index 時慢)，但叢集索引太多時 inster 會變慢，只是查詢變快 ( key 只是讓值不重複 )

### Count(*) > Count(col)

### < and >= 優於 between

### C# SQLBalkCopy 吃系統轉檔不做過多邏輯判斷，進什麼吃什麼

需補使用情境

## 正規表示式 Regx <a id="10"></a>

Regx DTO 標籤 應用

正向反向

Ctrl + F 也可吃 / 取代也可吃

檢查條件 / 限制輸入條件 JS C# 都有 Object Method

需補正則背後原理 & 效能關係
