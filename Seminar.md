# 研討會 & 日常

## 目錄

* [Topshelf & Quartz.Net](#1)
* [Dapper ORM](#2)
* [CAPTCHA 圖靈測試](#3)
* [SASS / LESS](#4)
* [CSharp 非同步程式](#5)
* [Angular pipe regx](#6)
* [SSRS SQL Server Reporting Services](#7)
* [Navicat Premium](#8)
* [SQL 效能調校](#9)
* [正規表示式 Regx](#10)
* [.Net Core ViewComponent](#11)
* [Flurl C# Library](#12)
* [Robots.txt 封鎖 / SEO 優化搜尋](#13)
* [Elasticsearch 搜尋引擎](#14)

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

* 查詢成本 執行計畫
* IN < EXISTS
* INSERT INTO (Table存在) < SELECT INTO (Table不存在) (通常直接備份時使用)
* Order by (無 index 時慢)，但叢集索引太多時 inster 會變慢，只是查詢變快 ( key 只是讓值不重複 )
* Count(*) > Count(col)
* < and >= 優於 between
* C# SQLBalkCopy 吃系統轉檔不做過多邏輯判斷，進什麼吃什麼

需補使用情境

## 正規表示式 Regx <a id="10"></a>

Regx DTO 標籤 應用

正向反向

Ctrl + F 也可吃 / 取代也可吃

檢查條件 / 限制輸入條件 JS C# 都有 Object Method

需補正則背後原理 & 效能關係

## .Net Core ViewComponent <a id="11"></a>

類似現代前端框架的 Component 概念，但後端渲染 SSR

可以 JS 呼 Controller 再回傳 VC

其實就是 .Net Core 因應沒有 MVC 的 Partial View 所做的升級版

主要應用可以資料來源同一個 Model 但不同套版

## Flurl C# Library <a id="12"></a>

nuget 安裝

應用 URL組裝 參數化系統設計

Get Post Async Task Await

Exception 應用

Header Download

Oauth

Get String Byte Stream ...

## Robots.txt 封鎖 / SEO 優化搜尋 <a id="13"></a>

#### 案例

高鐵還沒釋出被爬蟲爬到，因為測試站沒有 robots.txt

福華旅行社開發完後，SEO 無起色，使用 sitemap.xml 嘗試

---

#### 1 .robots.txt

檔名須小寫 root 目錄要讀的到 e.g. Angular 要放在靜態目錄之下

不允許...，啥檔案 like gitnone (內容寫法)

Google search console / robots tool

#### 2 .http 回應標頭 meta ( IIS 內設定 )

與 robots.txt 相比權重較大

如何看有無成功 ? 瀏覽器 dev tool Network X-Robot-tag

#### 3 .網址 Google Search Console 移除六個月

半天成效

#### 4 sitemap.xml 讓瀏覽器搜入提高 SEO 算分

sitemap 產生器，丟 root 目錄

GSC 丟 siemap

連線偵測，要求 google 搜入

#### 預防與總結

robot.txt 容易改動，多人協作或客戶有機會異動檔案時不建議

header meta 相對較保險，只有 MIS 有機會去異動

或者靠較嚴謹的流程管控，如申請測試站一律掛 header meta

- 補充 h1 container 容易被 bot 搜到 (HTML結構優化)

## Elasticsearch 搜尋引擎 <a id="14"></a>

分散式搜尋系統 / Java / 容易擴充 / 反向搜尋(分池計分)

etg 正向搜尋：計算每個分池 / 精確大小寫

專為英文做的 JAVAHOME ?

內建訪問服務

中（每字）英（空白間隔）

分析器　輔助避免中文過多分池　ＩＫＡ　同義池

自定義分析　／　ＭＡＰＰＩＮＧ　查詢使用

資料類型．．．　超過則跳過ＥＳ直接搜尋

#### 重點

1. 搜尋規則 (類似正則／全文檢索／模糊／精確)
2. 分池（分析套件）大小寫／繁簡體
3. 資料源（查詢結果或其他／備份ｓｎａｐｓｈｏｔ快照　？
4. 結果（分頁／Ｇｒｏｕｐｂｙ）

#### 總結

中鼎（斷池）醫學專有名詞　／　廢話就分池　／　簡單就利用　Ｇｏｏｇｌｅ搜尋ＡＰＩ

ｐａｒｓａｌｅ　主打公司加值應用／ＳＱＬ　Ｌｉｋｅ　人才庫

目前ｂｕｇ　中英代碼搜尋不到　ＴＣ１２３４５

## Visual Studio Spell Checker (拼字檢查套件)

* [Visual Studio Vession](https://marketplace.visualstudio.com/items?itemName=EWoodruff.VisualStudioSpellCheckerVS2017andLater)

* [Visual Studio Code Vession](https://marketplace.visualstudio.com/items?itemName=streetsidesoftware.code-spell-checker)

工具 => Spell Checker => Edit Global Configuration => add => [\u4e00-\u9fa5] => 重開即可排除中文

<https://blog.poychang.net/visual-studio-spell-checker/>

## C# RestSharp (Http的组件)

一般後端調用 API 都是使用 System.net.http => HttpClient

<https://dotblogs.com.tw/justforgood/2018/08/24/100629>

但 C# RestSharp 函式庫簡化了使用方式。

RestSharp 是一个轻量的，不依赖任何第三方的组件或者类库的Http的组件。

<https://zhuanlan.zhihu.com/p/29338111>

<https://github.com/restsharp/RestSharp>

<https://www.nuget.org/packages/RestClient/>

## Nuget (開源軟體包管理系統)

NuGet是一個自由開源軟體包管理系統。用於Microsoft開發平台。

藉由類似 cdnjs 的方式，載入線上 packge 所以要確認網址一定要能解析正確，nuget 管理介面不能放錯誤網址否則會影響其他套件載入。

<https://stackoverflow.com/questions/10240029/how-do-i-install-a-nuget-package-nupkg-file-locally>

<https://dotblogs.com.tw/OldNick/2017/03/24/162927>

## NLOG (Log工具)

C#中有許多好用的Log工具(如NLog、Log4net、Serilog)，

<https://ithelp.ithome.com.tw/articles/10207693>

<https://dotblogs.com.tw/stanley14/2017/02/15/nlog>

## 網站規劃 & UIUX & 設計規範

<http://homepage.ntu.edu.tw/~huangsl/dw8/dw8-Pre-procedure.pdf>

<https://ctmaxs.com/%E7%B6%B2%E9%A0%81%E8%A8%AD%E8%A8%88/%E7%B6%B2%E7%AB%99%E8%A8%AD%E8%A8%88%E8%88%87%E9%96%8B%E7%99%BC%E6%B5%81%E7%A8%8B/#i>

<https://www.ctkpro.com/blog/web-design-progress-and-schedule/>

<http://www.tbsa.tw/ezfiles/tbsa/download/attach/5/%BD%B2%A9%FA%AD%F5-%BA%F4%AF%B8%A5%F8%B9%BA%BBP%A4%B6%AD%B1%B3%5D%ADp.pdf>

<https://otoitsuki.info/%E7%B6%B2%E7%AB%99%E4%BC%81%E5%8A%83%E6%B5%81%E7%A8%8B-8e631cce494d>

<https://www.google.com/search?rlz=1C1CHBF_zh-TWTW905TW905&ei=RfhRX9KcKcKTr7wPt9eW-Aw&q=%E9%96%8B%E7%99%BC%E9%9A%8E%E6%AE%B5%E7%B6%B2%E7%AB%99%E4%BC%81%E5%8A%83%E6%B5%81%E7%A8%8B&oq=%E9%96%8B%E7%99%BC%E9%9A%8E%E6%AE%B5%E7%B6%B2%E7%AB%99%E4%BC%81%E5%8A%83%E6%B5%81%E7%A8%8B&gs_lcp=CgZwc3ktYWIQAzoECAAQQzoGCAAQBRAeUOkLWOkLYNsVaABwAHgAgAHXAYgBoQOSAQMyLTKYAQCgAQKgAQGqAQdnd3Mtd2l6wAEB&sclient=psy-ab&ved=0ahUKEwiS09SUiM_rAhXCyYsBHberBc8Q4dUDCA0&uact=5>

<https://ithelp.ithome.com.tw/users/20121038/ironman/3574>

<https://ithelp.ithome.com.tw/articles/10233696>

## JS 事件循環

<https://www.google.com/search?q=Event+Queue&source=lmns&bih=915&biw=1920&rlz=1C1CHBF_zh-TWTW905TW905&hl=zh-TW&sa=X&ved=2ahUKEwi_-KSB0YDsAhVWAqYKHbhYBZQQ_AUoAHoECAEQAA>

## IIS & SQL資料庫 部屬

<https://dotblogs.com.tw/mis2000lab/2017/07/12/IIS_WindowsAuth_ASPnet_SQL>

<https://blog.xuite.net/tolarku/blog/536261609-%5BIIS%5D+VS.NET+%E5%B0%88%E6%A1%88%E7%99%BC%E8%A1%8C%E8%B3%87%E6%96%99%E5%BA%AB%E9%8C%AF%E8%AA%A4+-+IIS+APPPOOL%5C.NET+v4.5+%E7%9A%84%E7%99%BB%E5%85%A5%E5%A4%B1%E6%95%97>

<https://dotblogs.com.tw/aken1215/2016/08/24/155102>

<http://lhzyaminabe.blogspot.com/2017/08/mvciis75mvc.html>

<https://dotblogs.com.tw/mis2000lab/2017/07/12/IIS_WindowsAuth_ASPnet_SQL>

## Visual Studio 視窗配置

<https://www.google.com/search?rlz=1C1CHBF_zh-TWTW905TW905&ei=TxVDX6GmEMuImAWNt72oCw&q=visual+studio+%E8%A6%96%E7%AA%97%E9%85%8D%E7%BD%AE+%E8%B7%91%E6%8E%89+&oq=visual+studio+%E8%A6%96%E7%AA%97%E9%85%8D%E7%BD%AE+%E8%B7%91%E6%8E%89+&gs_lcp=CgZwc3ktYWIQAzIFCAAQzQIyBQgAEM0COggIABCwAxDNAjoCCAA6BAgAEB5QhSpYjTdgtzhoAXAAeACAAUKIAa4BkgEBM5gBAKABAaABAqoBB2d3cy13aXrAAQE&sclient=psy-ab&ved=0ahUKEwjhiaPf1bLrAhVLBKYKHY1bD7UQ4dUDCAw&uact=5>

<https://kevintsengtw.blogspot.com/2015/02/visual-studio-part1.html>

## EF Codefirst

<https://dotblogs.com.tw/supershowwei/2016/04/11/000015>

<https://programmium.wordpress.com/2017/07/17/ef-code-first-auto-increment-key/>

## JS Array & List

<https://ithelp.ithome.com.tw/questions/10191125>

## LINQ

<https://stackoverflow.com/questions/21000287/date-difference-logic-in-linq>

<https://dotblogs.com.tw/chhuang/2008/05/01/3772>

<https://blog.xuite.net/f8789/DCLoveEP/23587655-LINQ+-+DISTINCT%E7%9A%84%E4%BD%BF%E7%94%A8>

<https://support.microsoft.com/zh-tw/help/2588635>

<http://coding.anyun.tw/2012/03/05/linq-to-entity-datatime-diff/>

<https://yangxinde.pixnet.net/blog/post/31357272>

<https://dotblogs.com.tw/dc690216/2009/09/13/10601>

<https://stackoverflow.com/questions/1042152/how-can-i-convert-iqueryablestring-to-a-string-array>

<https://dotblogs.com.tw/dc690216/2009/09/13/10601>

<https://stackoverflow.com/questions/7325278/group-by-in-linq>

## SQL Server 設計師模式關閉

<https://mitblog.pixnet.net/blog/post/39977377?m=off/>

## SQL

<https://www.fooish.com/sql/left-outer-join.html>

<https://stackoverflow.com/questions/1748794/is-there-an-arraylist-in-javascript>

<https://www.1keydata.com/tw/sql/sqlorderby.html>

## CSharp Foreach index

<http://jengting.blogspot.com/2014/08/foreach-index.html>

## CORS 預檢請求

預檢請求 就是為甚麼每次看network都會有兩條一樣的 但只有一條有response

<https://developer.mozilla.org/zh-TW/docs/Web/HTTP/CORS>

## Visual Studio 主題

<https://dotblogs.com.tw/junior78469/2013/11/24/131070>

<https://studiostyl.es/>

推薦下載

<https://drive.google.com/file/d/1fBGLVGSlYKN3WRAkaod5nRGJnrh1VbJ_/view?usp=sharing>
