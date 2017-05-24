# Hire Demo App

App criado para o MOBILE DEV CODE CHALLENGE.

![alt text](https://github.com/jbravobr/Assets/blob/master/Android_Capture.gif?raw=true "Android's capture")
![alt text](https://github.com/jbravobr/Assets/blob/master/iOs_Capture.gif?raw=true "iOS's capture")

## Pré-requisitos

É importante ter a versão mais recente do Xcode e também instalou o ** ANDROID SDK PLATFORM TOOLS 25.0.4 ** eo ** Android SDK (API 23) ** e / ou ** Android 7 (API 24) ** . De preferência API 23.

## Instalação 

```
Clone este repositório e abra a solução usando o Visual Studio para Mac (de preferência) ou o Visual Studio 2015 ou 2107 (ambos com as ferramentas Xamarin instaladas e atualizadas pelo canal STABLE)
```
## Algumas capturas de tela

![alt text](https://github.com/jbravobr/Assets/blob/master/Android_MovieList.png?raw=true "Android's capture")
![alt text](https://github.com/jbravobr/Assets/blob/master/Android_DetailsPage.png?raw=true "Android's capture")


![alt text](https://github.com/jbravobr/Assets/blob/master/iOS_MovieList.png?raw=true "iOS's capture")
![alt text](https://github.com/jbravobr/Assets/blob/master/iOs_DetailsPage.png?raw=true "iOS's capture")

## Componentes de terceiros (plug-ins via nuget ou instalação direta)

Estes foram os plugins utilizados

| Plug-ins|
| ------------------- |
|SyncFusion Rating Control|
|Prism Library|
|FFImageLoading|
|sqlite-net-pcl|
|SQLite Extensions|
|Xamarin Connectivity Plugin|
|PropertyChanged|
|Airbnb Lottie|
|Acr UserDialogs|
|Acr Settings|

### SyncFusion Rating Control

Syncfusion fornece uma gama de controles para Xamarin. Para esta App nós usamos o controle de classificação, no formato de estrelas para exibir a classificação média dos filmes
[Mais informações](https://help.syncfusion.com/xamarin/sfrating/overview)

### Prism Library

Usamos a biblioteca Prism para melhorar os recursos MVVM nativos da biblioteca Xamarin Forms e ter melhor controle e desempenho sobre a navegação dentro da App. Além de diminuir o acoplamento na App, permitindo uma maior testabilidade
[Mais informações](https://github.com/PrismLibrary/Prism)

### FFImageLoading

Utilizamos o plug-in FFImageLoading para maior agilidade e flexibilidade ao trabalhar com imagens, permitindo-nos tratar o borrão mais simples e a possibilidade de trabalhar com cache
[Mais informações](https://github.com/luberda-molinet/FFImageLoading)

### sqlite-net-pcl

Utilizamos o plug-in sqlite-net-pcl como o orquestrador do sistema de banco de dados para o aplicativo. Pensando em agregar mais valor à solução, introduzimos conceitos de dados offline, fazendo-nos usar esta solução para conseguir isso
[Mais informações](https://github.com/praeclarum/sqlite-net)

### SQLite Extensions

Usamos o plug-in SQLite Extensions como uma forma de manter um relacionamento saudável entre entidades possíveis no nosso aplicativo. Assim, sem alterações de esquema no banco de dados, podemos persistir e recuperar a forma completa de informação e relacionados
[Mais informações](https://bitbucket.org/twincoders/sqlite-net-extensions)

### Xamarin Connectivity Plugin

Utilizamos o Plug-in de Plug-in de Conectividade Xamarin para nos dar a flexibilidade de acessar os recursos de conectividade de ambas as plataformas via PCL
[Mais informações](https://github.com/jamesmontemagno/ConnectivityPlugin)

### PropertyChanged (Fody)

Usamos o plug-in PropertyChanged para tornar mais fácil usar propriedades "auto-observáveis" através da interface INotifyPropertyChanged e assim manter o padrão MVVM mais fluido
[Mais informações](https://github.com/Fody/PropertyChanged)

### Airbnb Lottie

Usamos o plug-in Airbnb Lottie para trazer e exemplificar como podemos trabalhar com animações de uma forma prática e performativa usando Xamarin Forms
[Mais informações](https://github.com/martijn00/LottieXamarin)

### Acr UserDialogs

Utilizamos o plug-in Acr UserDialogs para trabalhar com a exibição de alertas e mensagens personalizadas de forma simples através do projeto PCL
[Mais informações](https://github.com/aritchie/userdialogs)

### Acr Settings

Utilizamos o plug-in Acr Settings para que possamos acessar recursos de armazenamento baseados em valores-chave, padrões de plataforma
[Mais informações](https://github.com/aritchie/userdialogs)

## Built With

* [Xamarin Forms](https://www.nuget.org/packages/Xamarin.Forms/) - Xamarin Forms (Last Stable Version)
* [Mono](http://www.mono-project.com/docs/about-mono/releases/4.8.0/) - Mono (Last Stable Version)

## Authors

* **Rodrigo Amaro**

## License

This project is licensed under the MIT License 
