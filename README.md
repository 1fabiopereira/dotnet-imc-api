# IMC API

Está API foi desenvolvida com carater de estudo da tecnologia, possuindo apenas duas rotas. A presente API foi desenvolvida para alimentar um [Aplicativo](https://github.com/1fabiopereira/ionic-imc-calculator) também utilizado como forma de estudo e validação de algumas tecnologias.

## Instalação

Para fazer a instalação deste código basta executar o seguinte comando:

`git clone https://github.com/1fabiopereira/dotnet-imc-api.git`

## Execução

O projeto em questão é desenvolvido em **dotnet Core**, para que seja possível a execução é necessário que se tenha o ambiente devidamente configurado, o passo a passo da instação pode ser visto [aqui](https://dotnet.microsoft.com/download).

Com o ambiente devidamente configurado basta executar o seguinte comando para subir a aplicação:

`dotnet run`

## Rotas

Quando a aplicação estiver em execução duas rotas estão disponíveis:

- `GET http://localhost:5000/api/user`

- `POST http://localhost:5000/api/user`

Onde os parâmetros do POST são:

```json
{
    "name: "Fábio",
    "height": 1.71,
    "weight": 90
}
```

## Ambiente

A aplicação foi desenvolvido utilizando-se do seguinte ambiente, para o correto funcionamento é necessário que as versões sejam respeitadas.

```
.NET Core SDK (reflecting any global.json):
 Version:   2.1.503
 Commit:    4c506e0f35

Runtime Environment:
 OS Name:     elementary
 OS Version:  0.4.1
 OS Platform: Linux
 RID:         linux-x64
 Base Path:   /usr/share/dotnet/sdk/2.1.503/

Host (useful for support):
  Version: 2.1.7
  Commit:  cca5d72d48

.NET Core SDKs installed:
  1.0.4 [/usr/share/dotnet/sdk]
  2.1.503 [/usr/share/dotnet/sdk]

.NET Core runtimes installed:
  Microsoft.AspNetCore.All 2.1.7 [/usr/share/dotnet/shared/Microsoft.AspNetCore.All]
  Microsoft.AspNetCore.App 2.1.7 [/usr/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 1.0.5 [/usr/share/dotnet/shared/Microsoft.NETCore.App]
  Microsoft.NETCore.App 1.1.2 [/usr/share/dotnet/shared/Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.1.7 [/usr/share/dotnet/shared/Microsoft.NETCore.App]

To install additional .NET Core runtimes or SDKs:
  https://aka.ms/dotnet-download
```