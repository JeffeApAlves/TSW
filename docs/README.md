## Descrição Geral

Software de cadastro de pedido com notificação via UDP

## Comunicação

UDP socket

## Database first

Com a proposta de não ter cógido SQL junto ao fonte para facilitar manutenções futuras da base e do software 
a solução adotada foi o uso do entityframework onde a base de dados é toda abstraida inclusive as consultas 
que são armazeanadas na própria base.

Em POSoftware > Infra > Model1.edmx é possivel visualizar o MER da base. A manutenção do modelo está sendo 
mantida atraves da própria ferramenta do VS. 

## Code first

Para gerar o modelo

    enable-migrations
    update-database
    update-database -verbose -script

## Configuração 

Instalar os pacotes abaixo através do PMC:

    install-package entityframework
    install-package ninject
    install-package CommonServiceLocator
    install-package CommonServiceLocator.NinjectAdapter.Unofficial
