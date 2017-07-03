Descricao geral

Com a proposta de nao ter cogido SQL no codigo fonte para facilitar a manutencao da base e do software a solucao
adotada foi o uso do entityframework onde a base foi toda abstraida inclusive as consultas que seriam armazeanadas na 
propria base.
Nao foi preciso criar nenhuma stored procedure, mas se necessario seria abstraido da mesma forma.
Em POSoftware > Infra > Model1.edmx e possivel visualizar o MER da base(bem simples). A manutencao do modelo esta sendo 
mantida atraves da propria ferramenta do visual studio. 

InIcialmente foi tentado fazer um code first, mas optei por abortar. 

Para utilizacao de code first

enable-migrations
update-database
update-database -verbose -script


Instalar os pacotes abaixo atraves do PMC

install-package entityframework
install-package ninject
install-package CommonServiceLocator
install-package CommonServiceLocator.NinjectAdapter.Unofficial


JEFFERSON-PC\SQLEXPRESS

