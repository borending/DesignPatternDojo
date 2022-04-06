## 設計模式修練場
此專案為基於以下網站所進行的設計模式練習
https://www.dofactory.com/net/design-patterns

## 設計模式的基礎為物件導向原則：SOLID

### S : 單一職責，切分職責，不要混合或在內部呼叫其他面向的功能。
例如: 
1. 訂單跟寄信 的功能實作在不同的Service。
2. 屬於通用型功能，不要在內部牽扯其他業務邏輯:
假設寄信會再把TEMP 清掉，如果未來新需求有用到寄信但不需要清除TEMP，就可能會造成系統奇怪的BUG(如果是比較針對性的功能，別人都不會用那就沒差)。
但是要注意切分不要過細

### O : 開放封閉，已經開發完成的功能，應該要開放擴增，封閉修改
假設一段邏輯中針對A 物件的處理，如果A 有多種type，可以把主要處理邏輯中的A，使用介面或是泛型替代，個別type 的處理在各自的物件或介面中實作。例如：ViewModel 中的Build。如此一來當Type 增加的時候，因為主程式邏輯被抽象化所以不用修改，只要在Type 物件寫屬於他的邏輯。
開放(抽象類別方法、介面、泛型的)擴增，封閉(處理流程邏輯的)修改。
https://medium.com/@f40507777/%E9%96%8B%E6%94%BE%E5%B0%81%E9%96%89%E5%8E%9F%E5%89%87-open-closed-principle-31d61f9d37a5

### L : 里氏替換原則，繼承時，子類別要能完全替代父類別的功能 (尚未完全理解)
不要繼承到沒用到的介面
例如 : 
有一個介面"產出"，父類別實做的時候輸入限定為豬肉，輸出為原味香腸
當大家叫用這個介面，雖然不知道背後是誰實做的，但是已經約定好丟豬肉進去就會變香腸
如果有一個子類別繼承並複寫"產出" 這個功能，那他的輸入輸出必須要符合父類別的預期輸入輸出，必須遵守以下項目 : 
a. 不能改變輸入的合法範圍 : 例如不能限制只能輸入豬瘦肉，如果一樣的介面在不同地方背後的實做不一樣時，會變成參數有時候會過，有時候不會過。
b. 也不能改變輸出 : 不然子類別輸出的香腸是麻辣香腸，不吃辣的客人會生氣 XD
c. 外在的呼叫條件也要一樣 : 父類別背後也是被封裝的程式，如果他背後限制假日才能正常工作，卻在平日呼叫子類別，那可能會造成非預期的錯誤

我是不太懂啦，那不要複寫就好啦。
還是說，可以開放擴增，增加新的屬性 新的方法，但不要改變來自父類別的方法 ?

繼承是為了reuse 所以reuse 的地方就不能改，如果要改就需要用abstract 或用組合的

https://medium.com/@f40507777/%E9%87%8C%E6%B0%8F%E6%9B%BF%E6%8F%9B%E5%8E%9F%E5%89%87-liskov-substitution-principle-adc1650ada53

### I : 介面隔離原則
Overloaded 要用不同介面去區分

### D : 依賴反轉
ViewModel.Build 就是依賴反轉

---

## 設計模式 Design Patterns
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
5. Observer ( Event Listener ) 高
6. Strategy 高 v
7. Builder 中低
8. Adapter ( asList , toString ) 中高
9. State 中

References:
https://learningdaily.dev/the-7-most-important-software-design-patterns-d60e546afb0e?gi=45b79806400a
https://www.upgrad.com/blog/software-design-patterns/#Top_5_Popular_Software_Design_Patterns
https://www.quora.com/Which-are-the-most-useful-design-patterns