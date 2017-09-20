#TSW

##Descricao geral


Utilização de entityframework e UDP socket para comunicção entre aplicações

Com a proposta de não ter cógido SQL junto ao fonte para facilitar manutenções futuras da base e do software a solução
adotada foi o uso do entityframework onde a base de dados é toda abstraida inclusive as consultas que seriam armazeanadas na 
própria base.
Não foi preciso criar nenhuma stored procedure, mas se necessário seria abstraido da mesma forma.
Em POSoftware > Infra > Model1.edmx é possivel visualizar o MER da base. A manutenção do modelo está sendo 
mantida atraves da própria ferramenta do VS. 

Inicialmente foi tentado fazer um code first, mas optei por abortar. 

##Para utilizacao de code first

enable-migrations
update-database
update-database -verbose -script

##Configuração 

Instalar os pacotes abaixo através do PMC:

install-package entityframework
install-package ninject
install-package CommonServiceLocator
install-package CommonServiceLocator.NinjectAdapter.Unofficial
