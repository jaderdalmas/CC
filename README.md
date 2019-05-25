# CC
Current Account

> DDD (Domain-Driven Design)

É o design de aplicações direcionado a domínios, ou seja, um guia de arquitetura de aplicações com foco no entendimento dos diversos contextos e divisão do desenvolvimento a fim de segregar por domínio as responsabilidades de cada contexto. Este modelo é importante para o direcionamento da organização do desenvolvimento.

> Arquitetura baseada em microserviços

É o direcionamento do desenvolvimento em pequenos blocos e disponibilizados em forma de serviços, sendo que com a ajuda da organização do desenvolvimento temos responsabilidade única por serviço e similar por grupo de serviços ou microserviços. Os ganhos dessa implementação são a robustez e a independência dos serviços, mas seus desafios são desacoplar os serviços e identificar quais devem ser agrupados, sendo que seu crescimento dificulta sua manutenibilidade.

> Sincrona e Assincrona

A comunicação síncrona é quando a mensagem enviada é processada e devolvida antes do envio da próxima mensagem, sendo que a ordem das mensagens recebidas influência a resposta; podemos dizer que uma ligação telefônica é feita de modo síncrono, no qual ambos comunicadores estão disponíveis.
Já na comunicação assíncrona, as mensagens podem ser enviadas sem a necessidade do processamento das anteriores, sendo que a ordem das mensagens recebidas não influência a resposta; podemos dizer que mensagens telefônicas são feitas de modo assíncrono, no qual os comunicadores podem ou não estar disponíveis.