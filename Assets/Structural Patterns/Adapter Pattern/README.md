# Adapter Pattern 适配器模式
## Definition
クラスのインターフェイスを、クライアントが期待する別のインターフェイスに変換します。アダプタを使用すると、 互換性のないインターフェイスのためにそうでなければできないようなクラスを一緒に動作させることができます。</br>

Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.</br>

<br>将一个类的接口转换成客户希望的另外一个接口。适配器模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
	
![](https://github.com//Unity-Design-Pattern/blob/master/UML_Picture/adapter.gif)

## Participants

このパターンに参加しているクラスとオブジェクトは、以下の通りです。</br>
The classes and objects participating in this pattern are:

### Target   (ChemicalCompound)
* クライアントが使用するドメイン固有のインターフェイスを定義します。
* defines the domain-specific interface that Client uses.

### Adapter   (Compound)
* AdapteeインタフェースをTargetインターフェースに適応させます。
* adapts the interface Adaptee to the Target interface.

### Adaptee   (ChemicalDatabank)
* 適合・適用が必要な既存のインターフェイスを定義します。
* defines an existing interface that needs adapting.

### Client   (AdapterApp)
* Targetインターフェースに準拠したオブジェクトと連携しています。
* collaborates with objects conforming to the Target interface.


