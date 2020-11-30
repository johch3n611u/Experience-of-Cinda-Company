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
* [XXXXXXXXXXXXXX](#15)
* [XXXXXXXXXXXXXX](#16)
* [XXXXXXXXXXXXXX](#17)
* [XXXXXXXXXXXXXX](#18)
* [XXXXXXXXXXXXXX](#19)
* [XXXXXXXXXXXXXX](#20)
* [XXXXXXXXXXXXXX](#21)
* [XXXXXXXXXXXXXX](#22)
* [XXXXXXXXXXXXXX](#23)
* [XXXXXXXXXXXXXX](#24)
* [XXXXXXXXXXXXXX](#25)
* [XXXXXXXXXXXXXX](#26)
* [XXXXXXXXXXXXXX](#27)
* [XXXXXXXXXXXXXX](#28)
* [XXXXXXXXXXXXXX](#29)
* [XXXXXXXXXXXXXX](#30)
* [XXXXXXXXXXXXXX](#31)
* [XXXXXXXXXXXXXX](#32)
* [XXXXXXXXXXXXXX](#33)
* [XXXXXXXXXXXXXX](#34)
* [XXXXXXXXXXXXXX](#35)
* [XXXXXXXXXXXXXX](#36)
* [XXXXXXXXXXXXXX](#37)
* [XXXXXXXXXXXXXX](#38)
* [XXXXXXXXXXXXXX](#39)
* [XXXXXXXXXXXXXX](#40)
* [XXXXXXXXXXXXXX](#41)
* [XXXXXXXXXXXXXX](#42)
* [XXXXXXXXXXXXXX](#43)
* [XXXXXXXXXXXXXX](#44)
* [XXXXXXXXXXXXXX](#45)
* [XXXXXXXXXXXXXX](#46)
* [XXXXXXXXXXXXXX](#47)
* [XXXXXXXXXXXXXX](#48)
* [XXXXXXXXXXXXXX](#49)
* [XXXXXXXXXXXXXX](#50)
* [XXXXXXXXXXXXXX](#51)
* [XXXXXXXXXXXXXX](#52)
* [XXXXXXXXXXXXXX](#53)
* [XXXXXXXXXXXXXX](#54)
* [XXXXXXXXXXXXXX](#55)
* [XXXXXXXXXXXXXX](#56)
* [XXXXXXXXXXXXXX](#57)
* [XXXXXXXXXXXXXX](#58)
* [XXXXXXXXXXXXXX](#59)
* [XXXXXXXXXXXXXX](#60)
* [XXXXXXXXXXXXXX](#61)
* [XXXXXXXXXXXXXX](#62)
* [XXXXXXXXXXXXXX](#63)
* [XXXXXXXXXXXXXX](#64)
* [XXXXXXXXXXXXXX](#65)
* [XXXXXXXXXXXXXX](#66)
* [XXXXXXXXXXXXXX](#67)
* [XXXXXXXXXXXXXX](#68)
* [XXXXXXXXXXXXXX](#69)
* [XXXXXXXXXXXXXX](#70)
* [XXXXXXXXXXXXXX](#71)

## Topshelf & Quartz.Net <a id="1"></a>

<https://dotblogs.com.tw/wasichris/2017/01/14/165637>

利用服務跑排程，一個排程一個服務(Service)，要利用容器才能啟用多個服務 ? (名稱不能一樣)

job / trigger / schedule (取代 Timer) - 有支援 .new core

補充 : 直接手動執行而不是透過服務執行排程

## Dapper ORM <a id="2"></a>

| 比較       | EF x Dapper 混用 | EF      | Dapper  |
| ---------- | ---------------- | ------- | ------- |
| 操作性     | :cupid:          | :cupid: | -       |
| 效能       | :cupid:          | -       | :cupid: |
| 查詢精準度 | :cupid:          | -       | :cupid: |
| 可讀性     | :cupid:          | :cupid: | -       |

> Dapper 用於查詢

搭配 AutoMapping 等 map 才會好用， Dapper 的罩門是關聯

<https://github.com/shps951023/Trace-Dapper.NET-Source-Code>

---

### 20201028 補充

主要用於查詢

跟一般使用一樣需要連線

指定型別或動態接值

跟 EF 搭配可以直接用實體接值

支援參數化 / 自動對應

Muti data read

沒有延遲查詢功能

slapper automapper 套件可以解決聯集表 join 問題

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

### 20201014 補充 elasticsearch 進階應用 (感覺還是要實際遇到問題解決才懂) java 開源搜尋引擎

聚合 / 分池 / 關聯 / reindex / 分群搜尋 / kinana 管理頁面套件 要錢 可以驗證登入 / 全文檢索 / 雙引號會爆

## Visual Studio Spell Checker (拼字檢查套件) <a id="15"></a>

* [Visual Studio Vession](https://marketplace.visualstudio.com/items?itemName=EWoodruff.VisualStudioSpellCheckerVS2017andLater)

* [Visual Studio Code Vession](https://marketplace.visualstudio.com/items?itemName=streetsidesoftware.code-spell-checker)

工具 => Spell Checker => Edit Global Configuration => add => [\u4e00-\u9fa5] => 重開即可排除中文

<https://blog.poychang.net/visual-studio-spell-checker/>

## C# RestSharp (Http的组件) <a id="16"></a>

一般後端調用 API 都是使用 System.net.http => HttpClient

<https://dotblogs.com.tw/justforgood/2018/08/24/100629>

但 C# RestSharp 函式庫簡化了使用方式。

RestSharp 是一个轻量的，不依赖任何第三方的组件或者类库的Http的组件。

<https://zhuanlan.zhihu.com/p/29338111>

<https://github.com/restsharp/RestSharp>

<https://www.nuget.org/packages/RestClient/>

## Nuget (開源軟體包管理系統) <a id="17"></a>

NuGet是一個自由開源軟體包管理系統。用於Microsoft開發平台。

藉由類似 cdnjs 的方式，載入線上 packge 所以要確認網址一定要能解析正確，nuget 管理介面不能放錯誤網址否則會影響其他套件載入。

<https://stackoverflow.com/questions/10240029/how-do-i-install-a-nuget-package-nupkg-file-locally>

<https://dotblogs.com.tw/OldNick/2017/03/24/162927>

## NLOG (Log工具) <a id="18"></a>

C#中有許多好用的Log工具(如NLog、Log4net、Serilog)，

<https://ithelp.ithome.com.tw/articles/10207693>

<https://dotblogs.com.tw/stanley14/2017/02/15/nlog>

## 網站規劃 & UIUX & 設計規範 <<a id="19"></a>>

<http://homepage.ntu.edu.tw/~huangsl/dw8/dw8-Pre-procedure.pdf>

<https://ctmaxs.com/%E7%B6%B2%E9%A0%81%E8%A8%AD%E8%A8%88/%E7%B6%B2%E7%AB%99%E8%A8%AD%E8%A8%88%E8%88%87%E9%96%8B%E7%99%BC%E6%B5%81%E7%A8%8B/#i>

<https://www.ctkpro.com/blog/web-design-progress-and-schedule/>

<http://www.tbsa.tw/ezfiles/tbsa/download/attach/5/%BD%B2%A9%FA%AD%F5-%BA%F4%AF%B8%A5%F8%B9%BA%BBP%A4%B6%AD%B1%B3%5D%ADp.pdf>

<https://otoitsuki.info/%E7%B6%B2%E7%AB%99%E4%BC%81%E5%8A%83%E6%B5%81%E7%A8%8B-8e631cce494d>

<https://www.google.com/search?rlz=1C1CHBF_zh-TWTW905TW905&ei=RfhRX9KcKcKTr7wPt9eW-Aw&q=%E9%96%8B%E7%99%BC%E9%9A%8E%E6%AE%B5%E7%B6%B2%E7%AB%99%E4%BC%81%E5%8A%83%E6%B5%81%E7%A8%8B&oq=%E9%96%8B%E7%99%BC%E9%9A%8E%E6%AE%B5%E7%B6%B2%E7%AB%99%E4%BC%81%E5%8A%83%E6%B5%81%E7%A8%8B&gs_lcp=CgZwc3ktYWIQAzoECAAQQzoGCAAQBRAeUOkLWOkLYNsVaABwAHgAgAHXAYgBoQOSAQMyLTKYAQCgAQKgAQGqAQdnd3Mtd2l6wAEB&sclient=psy-ab&ved=0ahUKEwiS09SUiM_rAhXCyYsBHberBc8Q4dUDCA0&uact=5>

<https://ithelp.ithome.com.tw/users/20121038/ironman/3574>

<https://ithelp.ithome.com.tw/articles/10233696>

## JS 事件循環 <a id="20"></a>

<https://www.google.com/search?q=Event+Queue&source=lmns&bih=915&biw=1920&rlz=1C1CHBF_zh-TWTW905TW905&hl=zh-TW&sa=X&ved=2ahUKEwi_-KSB0YDsAhVWAqYKHbhYBZQQ_AUoAHoECAEQAA>

## IIS & SQL資料庫 部屬 <a id="21"></a>

<https://dotblogs.com.tw/mis2000lab/2017/07/12/IIS_WindowsAuth_ASPnet_SQL>

<https://blog.xuite.net/tolarku/blog/536261609-%5BIIS%5D+VS.NET+%E5%B0%88%E6%A1%88%E7%99%BC%E8%A1%8C%E8%B3%87%E6%96%99%E5%BA%AB%E9%8C%AF%E8%AA%A4+-+IIS+APPPOOL%5C.NET+v4.5+%E7%9A%84%E7%99%BB%E5%85%A5%E5%A4%B1%E6%95%97>

<https://dotblogs.com.tw/aken1215/2016/08/24/155102>

<http://lhzyaminabe.blogspot.com/2017/08/mvciis75mvc.html>

<https://dotblogs.com.tw/mis2000lab/2017/07/12/IIS_WindowsAuth_ASPnet_SQL>

## Nuget Case Converter 快速轉換命名方式 <a id="22"></a>

<https://marketplace.visualstudio.com/items?itemName=munyabe.CaseConverter>

## Visual Studio 視窗配置 <a id="23"></a>

<https://www.google.com/search?rlz=1C1CHBF_zh-TWTW905TW905&ei=TxVDX6GmEMuImAWNt72oCw&q=visual+studio+%E8%A6%96%E7%AA%97%E9%85%8D%E7%BD%AE+%E8%B7%91%E6%8E%89+&oq=visual+studio+%E8%A6%96%E7%AA%97%E9%85%8D%E7%BD%AE+%E8%B7%91%E6%8E%89+&gs_lcp=CgZwc3ktYWIQAzIFCAAQzQIyBQgAEM0COggIABCwAxDNAjoCCAA6BAgAEB5QhSpYjTdgtzhoAXAAeACAAUKIAa4BkgEBM5gBAKABAaABAqoBB2d3cy13aXrAAQE&sclient=psy-ab&ved=0ahUKEwjhiaPf1bLrAhVLBKYKHY1bD7UQ4dUDCAw&uact=5>

<https://kevintsengtw.blogspot.com/2015/02/visual-studio-part1.html>

## EF Codefirst <a id="24"></a>

<https://dotblogs.com.tw/supershowwei/2016/04/11/000015>

<https://programmium.wordpress.com/2017/07/17/ef-code-first-auto-increment-key/>

## JS Array & List <a id="25"></a>

<https://ithelp.ithome.com.tw/questions/10191125>

## LINQ <a id="26"></a>

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

## SQL Server 設計師模式關閉 <a id="27"></a>

<https://mitblog.pixnet.net/blog/post/39977377?m=off/>

## SQL <a id="28"></a>

<https://www.fooish.com/sql/left-outer-join.html>

<https://stackoverflow.com/questions/1748794/is-there-an-arraylist-in-javascript>

<https://www.1keydata.com/tw/sql/sqlorderby.html>

## CSharp Foreach index <a id="29"></a>

<http://jengting.blogspot.com/2014/08/foreach-index.html>

## CORS 預檢請求 <a id="30"></a>

預檢請求 就是為甚麼每次看network都會有兩條一樣的 但只有一條有response

<https://developer.mozilla.org/zh-TW/docs/Web/HTTP/CORS>

## Visual Studio 主題 <a id="31"></a>

<https://dotblogs.com.tw/junior78469/2013/11/24/131070>

<https://studiostyl.es/>

推薦下載

<https://drive.google.com/file/d/1fBGLVGSlYKN3WRAkaod5nRGJnrh1VbJ_/view?usp=sharing>

## Visual Studio Code Lens display Git info <a id="32"></a>

Enterprise、Professional 似乎要 企業版與專業版才有 ...

<https://stackoverflow.com/questions/55610991/is-there-any-codelens-add-on-available-that-shows-the-git-history-of-the-given-m>

## SQL USE DBNAME <a id="33"></a>

<https://stackoverflow.com/questions/10461861/use-database-command-on-sql-plus-oracle-11gr1>

## EF DBFirst 使用 DataAnnotations 屬性 與繼承 EF 實體 <a id="34"></a>

<https://dotblogs.com.tw/chentingw/2016/11/28/235523>

## HashSet 內容不重複的 Set <a id="35"></a>

<https://www.google.com/search?q=HashSet&rlz=1C1CHBF_zh-TWTW905TW905&oq=HashSet&aqs=chrome..69i57j0l7.549j0j7&sourceid=chrome&ie=UTF-8>

## Angular TypeScript 非同步 <a id="36"></a>

```TypeScript
getDataUsingSubscribe() {
	this.httpClient.get<Employee>(this.url).subscribe(data => {
	this.subscribeResult = data;
	console.log('Subscribe executed.')
	});
	console.log('I will not wait until subscribe is executed..');
	}

改成下面

async getAsyncData() {
	this.asyncResult = await this.httpClient.get<Employee>(this.url).toPromise();
	console.log('No issues, I will wait until promise is resolved..');
	}
```

<https://medium.com/media/5283ff33e9bd30397e3cf21f953daac1>

<https://medium.com/@balramchavan/using-async-await-feature-in-angular-587dd56fdc77>

## Exception.StackTrace 比較有用最好從最內層丟到最外 <a id="37"></a>

```json
{
    "PageSize": 0,
    "PageNum": 0,
    "TotalPages": 0,
    "TotalItems": 0,
    "Entries": [],
    "HasPreviousPage": false,
    "HasNextPage": false,
    "StackTrace": "   於 System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)\r\n   於 System.Nullable`1.get_Value()\r\n   於 Mxic.ITC.Portal.Service.BatchService.PAM115() 於 C:\\Users\\rognp\\Desktop\\旺宏_sourcecode\\MxicAppSample\\Mxic.App.Sample\\Mxic.ITC.Portal.Service\\Batch\\BatchService.cs: 行 1305",
    "StatusCode": 2
}
```

## LINQ GroupBy <a id="38"></a>

<https://dotblogs.com.tw/noncoder/2019/03/25/Lambda-GroupBy-Sum>

## Nuget Case Converter 套件 快速重構命名方法 <a id="39"></a>

<https://marketplace.visualstudio.com/items?itemName=munyabe.CaseConverter>

## AWS IPV6 應用 <a id="40"></a>

USECASE 高鐵 登入驗證 IP 需前後相同否則前端登入踢出

Azure 不提供

VPC 虛擬網路

安全性群組 (防火牆)

VM(很多設定)

站台架設 DNS IIS 防火牆設定

IPV6 > 4 預設

網卡同時包含 4 & 6

Client 只能選一個用

Site 吃 2 種 但要設定

---

jsonp - cors

json - cors 標頭

xmlhttp... / fetch 都有同源政策

src att 無視 cors ?

cdn 跨網域

## Csharp Docx 套件 <a id="41"></a>

Word 套印

修改內容 / 表格化

Templt 套版

pdf 通常 html 轉

## Line API (Bot / Notify / Login) <a id="42"></a>

註冊通知取得使用者資料選群組

類似一個人要把那個人的帳號加入，必須要把這個機器人的 token 存入 db 已再次使用

驗證 code 取客戶資料，透過 httpclient 由後端與 line api 溝通

平台已經有一些原本要寫 code 的功能但是要是官方付費帳戶

限制 ? bot 要錢 發送量 ?

收費 ?

應用情境 ?

line 註冊 平台上的帳號與賴綁定，做一些別的應用

bot 一問一答互動 多個框或特定字串

---

登入 另一個套件 類似 google 驗證 api

可以組 flex 發送

推波 push 要錢

其他有免費或使用扣打要去官網查

---

notify 與 push 差別在於 notify 是群發 ， Push 是私聊

使用情竟 客戶申請官方帳號有養人要讓特定的人進平台

官方帳號才有管理 crm 客戶管理其實有 line gui 管理後台

其餘要用 line develop

同個 providers 才會通，可以有管理員幫設定不用直接給權限 可以設定管理員

人工回應或機器人

要注意是綁定對話框

## UnitTest <a id="42"></a>

<https://docs.google.com/presentation/d/1IEZ3Ow6EekNYDxqzI9toHEgPiagYbZTiffCKjdfXha0/edit#slide=id.ga4518fb1b2_2_7>

<https://github.com/johch3n611u/Experience-of-Cinda-Company/tree/master/Meeting.SoftwareTesting>

## oracle 臨時表應用 <a id="43"></a>

<https://freetoad.pixnet.net/blog/post/25444612>

<http://www.aspphp.online/shujuku/oraclesjk/Oraclejc/201701/93025.html>

<https://www.itread01.com/content/1549304681.html>

<https://byron0920.pixnet.net/blog/post/85759990>

## String.TrimEnd 方法 去除尾數的 char <a id="44"></a>

<https://docs.microsoft.com/zh-tw/dotnet/api/system.string.trimend?view=netcore-3.1>

取得尾數 <https://blog.xuite.net/i20254/Work/111369008>

<https://blog.csdn.net/xushaozhang/article/details/77146091>

## Angular 元件改 style <a id="45"></a>

```css
::ng-deep .closeDateDropdown .ui-dropdown-label {
    color: blue;
    font-weight:bold;
 }
```

```html
<p-dropdown
styleClass="closeDateDropdown"
[disabled]="this.items.Status == 'ThreeOfOneWork' || this.items.Status === 'Closed' || this.items.Status === 'Invalid'"
appendTo="body" [options]="this.DetailCloseDate" required [(ngModel)]="items.CloseDate"
[disabled]="item.Disabled==false">
</p-dropdown>
```

## linq order by <a id="46"></a>

<https://ithelp.ithome.com.tw/articles/10104089>

## oracle 坑 <a id="47"></a>

搭配 Ef 如果有新增 ef， db也要新增不然 會錯，如果同時也在 transation 會 lock db 直接卡死，此時如無 session 或相關權限 直接等於放棄急救...

<https://www.twblogs.net/a/5b8c48482b7177188331e0d9>

ORA-00054

## EF 版本更新錯誤 <a id="48"></a>

<https://www.coder.work/article/2615671>

## C# 字串處理 <a id="49"></a>

string.IsNullOrEmpty(ele.AccountDisableFormPortalNo)

string.empty <https://jasper-it.blogspot.com/2014/08/c-string-stringempty-is-more-efficient.html>

split <https://codertw.com/%E7%A8%8B%E5%BC%8F%E8%AA%9E%E8%A8%80/641792/>

## Swiper 輪播套件 <a id="50"></a>

<https://hackmd.io/@chupai/BkohH4KzL>

## css-background-patterns 背景產生器 <a id="51"></a>

<https://free.com.tw/css-background-patterns/>

## Google obfuscator Tool 混淆 <a id="52"></a>

tool.css-js.com

UglifyJS

WebWoker js ? 線呈

web api (pwa)

## HAP (HTML Agility Pack) 爬蟲 解析器 nuget 套件 <a id="53"></a>

Node Select XML 結構

Xpath 瀏覽器右鍵 COYP 可以取

或 CSS Selector nuget 套件

## XX.AA ?? Empty 安全措施 <a id="54"></a>

string.isNullorEmpty and Withespase

## Transtain 交易 <a id="55"></a>

ACID, 樂觀悲觀 Lock

鎖定模式 不當鎖定影響 隔離層級

鎖定粒度 鎖定範例

nolock(共用鎖定) tablelock ... 撈的到 補SQL

### 情境

開始

一堆邏輯

儲存時鎖死

存完釋放

不是一開始鎖


新隔離層級 SNAPSHOT TEMP 暫存模式

## og.title <a id="56"></a>

## Linq Queryable <a id="57"></a>

才能用如以下語法

```C#
data.Where(x => 
EntityFunctions.DiffMonths(x.SIGN_FORM_MAIN.CREATE_DATE, DateTime.Now) <= 3 
&&
EntityFunctions.DiffMonths(x.SIGN_FORM_MAIN.CREATE_DATE, DateTime.Now) >= -3);
```

## .NET API 屬性路由 <a id="58"></a>

EnabledAnonymous

<https://www.google.com/search?q=.NET+API+Attributes&rlz=1C1CHBF_zh-TWTW905TW905&oq=.NET+API+Attributes&aqs=chrome..69i57.1436j0j1&sourceid=chrome&ie=UTF-8>

## Oracle Update Date <a id="59"></a>

> UPDATE PAMV2.PAM_IF_RESIGN SET ACCOUNT_CLOSE_DATE = DATE '2020-12-13'; 

<https://stackoverflow.com/questions/13497130/updating-a-date-in-oracle-sql-table/13497380>

## CSharp new 用法 <a id="60"></a>

```c#
public string Approved(HighPermissionForm Data, SignFormMain Sign)
        {
            foreach (var data in Data.Details)
            {
                var account = new Account();
                account.RefType = (byte)EnumAccountRefType.PAMHighPermission;
                account.FunctionType = (byte)EnumAccountFunctionType.HighPermission;

                if (Data.ActionType == (byte)EnumAccountActionType.New)
                {
                    account.Group = data.Group;
                    account.EmpNo = data.EmpNo;
                    account.EmpName = data.EmpName;
                    account.DeptNo = data.DeptNo;
                    account.ManageType = data.ManageType;
                    account.UpdaterEmpNo = Sign.ApplicanterEmpNO;
                    account.Attachment = Data.UploadFile;
                    new HighPermissionRepository().Add(account);
                }
                else
                {
                    account.Id = (decimal)data.DelRefId;
                    account.LastRefSignFormId = Sign.SignFromID;
                    new HighPermissionRepository().Remove(account);
                }
            }
            return "";
        }
```

## CSharp AutofacResolverHelper.Current.Container.ResolveNamed <a id="61"></a>

```C#
public class PageQuery<T>
    {
        public OrderBy OrderBy { get; set; }
        public int PageSize { get; set; } = 9999999;
        public int PageNum { get; set; } = 1;
        public T QueryObject { get; set; }
        public string Sort { get; set; } = "ID";
        public SortDirection SortDirection { get; set; } = SortDirection.Desc;
        public LazyLoadEvent LoadEvent { get; set; }
    }
    public class OrderBy
    {
        public string Field { get; set; }
        public int Type { get; set; }
    }
    public enum SortDirection
    {
        Asc = 1,
        Desc = 2
    }
--------------------------------------------------------------------------------------------------
public class AccountShift : Profile
    {
        public AccountShift()
        {
            CreateMap<ACCOUNT, Account>()
                        .ForMember(s => s.Id, opt => opt.MapFrom(s => s.ID))
                        .ForMember(s => s.FunctionType, opt => opt.MapFrom(s => s.FUNCTION_TYPE))
                        .ForMember(s => s.AccountType, opt => opt.MapFrom(s => s.ACCOUNT_TYPE))
                        .ForMember(s => s.IsCross, opt => opt.MapFrom(s => s.ISCROSS))
                        ;

            CreateMap<Account, ACCOUNT>()
                .ForMember(s => s.ID, opt => opt.MapFrom(s => s.Id))
                .ForMember(s => s.FUNCTION_TYPE, opt => opt.MapFrom(s => s.FunctionType))
                .ForMember(s => s.ACCOUNT_TYPE, opt => opt.MapFrom(s => s.AccountType))
                .ForMember(s => s.ISCROSS, opt => opt.MapFrom(s => s.IsCross))
                ;
        }
    }
}

--------------------------------------------------------------------------------------------------
                    var ACCOUNT = Entities.ACCOUNT.FirstOrDefault(x => x.ID == Item.AccountId);

                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile<AccountShift>();
                    });
                    var mapper = config.CreateMapper();
                    var Account = mapper.Map<Account>(ACCOUNT);
                    AutofacResolverHelper.Current.Container.ResolveNamed<IAccessRepository>(
                         ((EnumAccountFunctionType)Account.FunctionType).ToString()).Remove(Account);
```

## CSharp Debug 時不執行 [Conditional("DEBUG")] <a id="62"></a>

<https://dotblogs.com.tw/joysdw12/2014/03/14/asp-net-debug-release-if-else-conditional>

<https://stackoverflow.com/questions/6927263/enable-code-on-release-compilation>

## Oracle CSharp 抓最大 Id <a id="63"></a>

> var autoincrementId = Entities.ACCOUNT.Select(x => x.ID).DefaultIfEmpty(0).Max() + 1;

排除 table 是空的撈不到東西的狀況

## LINQ Not in <a id="64"></a>

<https://dotblogs.com.tw/dc690216/2009/09/13/10601>

## .NET 快取 <a id="65"></a>

<https://www.google.com/search?q=.net+%E5%BF%AB%E5%8F%96&oq=.net+%E5%BF%AB%E5%8F%96&aqs=chrome..69i57j69i65.8615j0j1&sourceid=chrome&ie=UTF-8>

前端 / 後端 快取

.NET Core 2 以上 內建 ResponseCache

<https://ithelp.ithome.com.tw/articles/10203293>

使用方式 Attr 掛在接口上 有參數可以調整

ConfigureService 要設置

有限制 e.g. get/put no post

舊的 outputCatch

## TypeScript <a id="66"></a>

型別 / 包 ES5,6

Tools - CSharp2TS / Eslint / TSlint

## 驗證模式 <a id="67"></a>

### SSO - 單一登入 Single sign-on

一種設計方式/平台，能夠整合各平台帳號，類似單一入口

### AD系統 - Active Directory

LDAP / 是微軟Windows Server中，負責架構中大型網路環境的集中式目錄管理服務（Directory Services）

### Windows 驗證 / IIS 開啟 WINDOWS 驗證

不用再打一次帳號密碼，默認吃 WINDOWS OS 開啟時輸入的帳密且如果都設定好，可以間接串 AD

BOWERS 網域 要綁 間接串 AD

### OAuth - 委任授權

資料 token 丟來丟去

### OIDC - OpenID連線

類似上述只是多丟了一些東西

## JWT - JSON Web Token <a id="68"></a>

<https://yami.io/jwt/>

JSON Web Token (JWT) 是由 Auth0 所提構出的一個新 Token 想法，這並不是一套軟體、也不是一個技術

## SQL 查詢技巧 UNION <a id="69"></a>

<https://www.itread01.com/content/1546941990.html>

## SYSTEM 系統 <a id="70"></a>

ERP：Enterprise resource planning

POS：Point of Sale

CRM：Customer Relationship Management

BI：Business Intelligence

eCOM：支援購物車、整合線上金流，可成立訂單，服務消費者做線上銷售的品牌官網。

app：

OMS：Order Management System

CDP：Customer Data Platform

<https://www.inside.com.tw/article/21346-8-info-systems-of-retail>

## IT學習歷程 <a id="71"></a>

一开始是增删改查。。。。

日子久了你就发现你的代码越来越复杂。。。。就会涉及到业务拆分。架构设计。

常用的静态资源比如图片，js文件占用带宽怎么办。。。。静态资源服务器。

文件的上传下载怎么提高效率。。。。。。。。。FastDFS。

消息推送的实时性怎么保证。。。。。。建立长连接吧netty，websockt。

用户开始越来越多了，一台服务器不够要多台。。。就会涉及到负载均衡。。。。

多台服务器下他们中间会有通信问题。。。。这就涉及到RPC远程调用。。。。。

特别是支付和认证这块。。。会产生对方接口调用过慢，网络等影响。就需要异步。。。

同时使用人数过多，不能让服务器爆炸吧。。。。。很多地方就要用到消息队列。。。

数据库数据量过大影响效率怎么办。。。。建立索引，分表分库。

常用信息访问过多占用资源怎么办。。。。。。NOSQL缓存吧。。。

IM下的点对点传输，多用户下的关系指数增长。。。。。。

以上是常见的场景应用。。。。背后涉及到的东西各有深度。。。。

设计模式，CAP，架构模式，SOA，服务治理，WebService,通讯协议，文件编码类型。。。。。

书到用时方恨少，你觉得没啥是因为你没用到。。。

## Yahoo奇摩新聞: 什麼是行銷自動化漏斗？所有企業都需要行銷自動化嗎？. <a id="72"></a>

<https://tw.news.yahoo.com/%E4%BB%80%E9%BA%BC%E6%98%AF%E8%A1%8C%E9%8A%B7%E8%87%AA%E5%8B%95%E5%8C%96%E6%BC%8F%E6%96%97-%E6%89%80%E6%9C%89%E4%BC%81%E6%A5%AD%E9%83%BD%E9%9C%80%E8%A6%81%E8%A1%8C%E9%8A%B7%E8%87%AA%E5%8B%95%E5%8C%96%E5%97%8E-080922115.html>
