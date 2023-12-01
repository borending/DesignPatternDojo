## 設計模式修練場
此專案為基於以下網站所進行的設計模式練習
https://www.dofactory.com/net/design-patterns

設計模式是基於物件導向的延伸
故學習的順序為：物件導向基礎及原則 > 設計模式
物件導向基礎的封裝、繼承等等... 不多做解釋，直接從物件導向原則SOLID 開始


## 1. 物件導向原則：SOLID

### S 單一職責: 一個模組應該只對一個角色(行為)而改變。
程式碼依照模組分類，把相關的功能凝聚在一起。
分離不同角色使用的程式碼，以免修改程式之後因為耦合造成非預期的錯誤。
例如：
1. 訂單 跟 寄信 功能實作在不同的類別(Service)。
2. 一個類別或一個方法，只處理一個業務邏輯:
假設現有的寄信方法(SendMail)，寄完信會再把Windows TEMP 清掉。如果未來新需求有用到寄信功能但不需要清除TEMP，錯誤引用SendMail 這個方法就可能會造成系統奇怪的BUG(如果是比較針對性的功能，別人都不會用那就沒差)。
但是單一職責最難的就是切分的拿捏，要注意切分不要過細，以免造成開發過於複雜。

### O 開放封閉: 透過結構的設計，使其能透過新增程式來變更系統功能或行為，而不需要修改原有的程式
系統架構會以階層來做分離，使較高階層(核心)部分不會因為低階層(外圍)的修改而受到影響

假設一段邏輯中針對A 物件的處理，如果A 有多種type，可以把主要處理邏輯中的A，使用介面或是泛型替代，個別type 的處理在各自的物件或介面中實作。例如：ViewModel 中的Build。如此一來當Type 增加的時候，因為主程式邏輯被抽象化所以不用修改，只要在Type 物件寫屬於他的邏輯。
開放(抽象類別方法、介面、泛型的)擴增，封閉(處理流程邏輯的)修改。
https://medium.com/@f40507777/%E9%96%8B%E6%94%BE%E5%B0%81%E9%96%89%E5%8E%9F%E5%89%87-open-closed-principle-31d61f9d37a5

### L 里氏替換: 針對繼承的原則，子類別要能完全替代父類別的功能。 new 
### L : 里氏替換原則，繼承時，子類別要能完全替代父類別的功能。

例如 : 
有一個介面"產出"，父類別繼承"產出"介面，實做的時候輸入限定為豬肉，輸出為原味香腸
當大家叫用這個介面，雖然不知道背後是誰實做的，但是已經約定好丟豬肉進去就會變香腸
如果有一個子類別繼承並複寫"產出" 這個功能，那他的輸入輸出必須要符合父類別的預期輸入輸出，必須遵守以下項目 : 
a. 不能改變輸入的合法範圍 : 例如不能限制只能輸入豬瘦肉，如果一樣的介面在不同地方背後的實做不一樣時，會變成參數有時候會過，有時候不會過。
b. 也不能改變輸出 : 不然子類別輸出的香腸是麻辣香腸，不吃辣的客人會生氣 XD
c. 外在的呼叫條件也要一樣 : 父類別背後也是被封裝的程式，如果他背後限制假日才能正常工作，卻在平日呼叫子類別，那可能會造成非預期的錯誤

我是不太懂啦，那不要複寫就好啦。
還是說，可以開放擴增，增加新的屬性 新的方法，但不要改變來自父類別的方法 ?

繼承是為了reuse 所以reuse 的地方就不能改，如果要改就需要用abstract 或用組合的
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