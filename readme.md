## 設計模式修練場
此專案為基於以下網站所進行的設計模式練習
https://www.dofactory.com/net/design-patterns

設計模式是基於物件導向的延伸
故學習的順序為：物件導向基礎及原則 > 設計模式
物件導向基礎的封裝、繼承等等... 不多做解釋，直接從物件導向原則SOLID 開始


## 1. 物件導向原則：SOLID
### 單一職責 SRP (Single Responsibility Principle)
>一個模組應該只對一個角色(行為)而改變。
1. 一個類別或一個方法，只處理一種業務邏輯
例如：一個名為SendMail 的方法，裡面只做寄信動作；一個名為PdfService 的類別，裡面只提供操作PDF相關的功能
2. 把提供相關功能的程式碼凝聚在一起，形成模組
例如："處理訂單"跟"寄信"功能實作在不同的類別(Service)。
3. 分離不同模組(角色) 使用的程式碼，以免修改程式之後因為耦合造成非預期的錯誤。
例如：兩個模組共用到的程式，因為某一個模組的需求而修改時，將其共用程式碼分離。

SRP的難點的就是切分的拿捏，要注意切分不要過細，以免造成開發過於複雜。
https://medium.com/程式愛好者/使人瘋狂的-solid-原則-單一職責原則-single-responsibility-principle-c2c4bd9b4e79

### 開放封閉 OCP (Open-Closed Principle)_____________[待補充]
>透過結構的設計，使其能透過新增程式來變更系統功能或行為，而不需要修改原有的程式
系統架構會以階層來做分離，使較高階層(核心)部分不會因為低階層(外圍)的修改而受到影響

1. 透過撰寫新程式碼，以新增功能
2. 當元件A 需要用到原有元件B 的程式，則使用介面注入B 元件，保護B 元件原有邏輯以免受到影響
此時元件關係為A 依賴於B 的單向依賴，故A 的修改不會異動到B 的原有程式

開放(抽象類別方法、介面、泛型的)擴增，封閉(處理流程邏輯的)修改。
https://medium.com/@f40507777/%E9%96%8B%E6%94%BE%E5%B0%81%E9%96%89%E5%8E%9F%E5%89%87-open-closed-principle-31d61f9d37a5
https://medium.com/程式愛好者/使人瘋狂的-solid-原則-開放封閉原則-open-closed-principle-f7eaf921eb9c
https://igouist.github.io/post/2020/10/oo-11-open-closed-principle/

### 里氏替換 LSP (Liskov Substitution Principle)
>若B 是A 的子型態，則B 要能完全替代A 的功能。
故將父型態替換成子型態後，原有的程式不需改變，也不會發生任何錯誤或異常。

1. 先驗條件不可以強化：輸入放寬，參數或限制不應該比父類別多
例如：父型態要求輸入長度最長50 的字串，則子型態的要求長度不能小於50
否則替換成子型態後，原本的合法輸入會產生錯誤結果
2. 後驗條件不可以弱化：輸出緊縮，回饋不應該比父型態少
例如：四輪跟二輪都是"汽車"，父型態輸出產品"二輪"，則子型態的輸出不能放寬為"汽車"
否則替換成子型態後，原本接收"二輪"的地方拿到"四輪"會產生錯誤結果

原本的LSP 只關心繼承問題，後來衍生到介面及實作也適用此原則。
備註：基於LSP原則來看，繼承時應該要思考這個子類別能不能做到父類別期望的行為，不要因為單純為了reuse 而繼承。
https://igouist.github.io/post/2020/07/oo-4-inheritance/
https://medium.com/@f40507777/%E9%87%8C%E6%B0%8F%E6%9B%BF%E6%8F%9B%E5%8E%9F%E5%89%87-liskov-substitution-principle-adc1650ada53

### I 介面隔離: 避免依賴於不使用的東西
Overloaded 要用不同介面去區分

### D 依賴反向: 細節應該依賴於策略  
ViewModel.Build 就是依賴反轉

---

## 2. 設計模式 Design Patterns
結合了各種物件導向 SOLID設計心法，而產生的設計規範
主要可以分為三大類：

1. 創建型模式 Creational
2. 結構型模式 Structural
3. 行為型模式 Behavioral

很明顯的，從各自的命名可以推測出使用的場景

根據統計，最常用的設計模式為下：

1. Singleton 中高 v
2. Decorator 中
3. Command 中高
4. Factory ( Action Mapping ) 高 v
5. Observer ( Event Listener ) 高 v
6. Strategy 高 v
7. Builder 中低
8. Adapter ( asList , toString ) 中高
9. State 中

References:
https://learningdaily.dev/the-7-most-important-software-design-patterns-d60e546afb0e?gi=45b79806400a
https://www.upgrad.com/blog/software-design-patterns/#Top_5_Popular_Software_Design_Patterns
https://www.quora.com/Which-are-the-most-useful-design-patterns