# Diseño del Patrón Factory Method

Este documento describe el diseño del patrón **Factory Method** aplicado al dominio de las tarjetas de crédito.  

El objetivo del patrón es **definir una interfaz para crear objetos**, pero dejar que las subclases decidan qué clase instanciar.  
De esta manera se promueve la **desacoplación** entre el código cliente y las clases concretas que implementan la interfaz común.

El diseño incluye los siguientes elementos principales:
- **ICreditCard**: Interfaz común para todas las tarjetas de crédito.
- **MoneyBack, Platinum y Titanium**: Implementaciones concretas de tarjetas de crédito.
- **CreditCardFactoryMethod**: Clase abstracta que define el método `CreateProduct`.
- **MoneyBackFactoryMethod, PlatinumFactoryMethod y TitaniumFactoryMethod**: Fábricas concretas que crean instancias de cada tipo de tarjeta.
- **CreditCardFactory**: Cliente que utiliza el Factory Method para obtener la tarjeta deseada.

Puedes visualizar el diagrama UML en el siguiente archivo:  

👉 [Ver diagrama Mermaid](mermaid.md)
