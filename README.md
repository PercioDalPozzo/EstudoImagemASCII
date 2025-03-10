# ASCII Image Converter

## Descrição

Este é um projeto de estudo desenvolvido para ser executado via linha de comando (CLI). O objetivo é carregar uma imagem, processar seus pixels e converter a informação de luminosidade em caracteres ASCII, gerando um arquivo de texto com a representação visual da imagem.

## Funcionalidades

- Carregamento de imagens em formatos comuns: JPEG, PNG, BMP, GIF, TIFF.
- Leitura pixel a pixel para extração da luminosidade.
- Conversão da luminosidade em caracteres ASCII correspondentes.
- Geração de um arquivo `.txt` com a representação ASCII da imagem.
- Possibilidade de configurar diferentes métodos de cálculo de luminosidade.
- Diferentes opções de "paleta de cores" para conversão em ASCII, com variações de 2, 5, 10 e 20 caracteres.
- Configuração de resolução em percentual, permitindo ajustar a relação entre pixels e caracteres ASCII.

## Como funciona

1. A imagem é carregada e convertida para tons de cinza.
2. Cada pixel tem sua luminosidade analisada.
3. Dependendo do valor de luminosidade, um caracter ASCII é atribuído.
4. O resultado é salvo em um arquivo `.txt`, onde os caracteres ASCII formam uma representação visual da imagem original.

## Requisitos

- .NET 6 ou superior
- Biblioteca:
  - SixLabors.ImageSharp (para manipulação de imagens)

## Instalação

```bash
dotnet add package SixLabors.ImageSharp
```

## Classe `PixelConverter`

A classe `PixelConverter` é responsável por converter a luminosidade de um pixel em um caracter ASCII correspondente. Nela, pode ser configurada uma "paleta de cores", onde se define quais caracteres representam diferentes níveis de brilho. Essa paleta pode ser ajustada para obter melhor contraste e qualidade visual na conversão, sendo possível escolher entre conjuntos de 2, 5, 10 ou 20 caracteres para um nível maior de detalhes.

Também é possível definir a resolução da conversão em percentual:

- **100%**: Cada pixel da imagem será convertido em um único caracter ASCII.
- **50%**: Cada caracter ASCII representará um bloco de 2x2 pixels.
- **25%**: Cada caracter ASCII representará um bloco de 4x4 pixels.

Outros valores podem ser configurados conforme necessidade para ajustar a resolução e nível de detalhe.

## Classes de Luminosidade

O cálculo da luminosidade pode ser ajustado por diferentes classes, permitindo um ajuste fino conforme as cores da imagem original. Normalmente, utiliza-se a classe `Luminosidade_R21_G71_B01`, que representa melhor a percepção de luminosidade do olho humano, considerando os pesos:

- **21%** Vermelho (R * 0.21)
- **71%** Verde (G * 0.71)
- **07%** Azul (B * 0.07)

Essa distribuição reflete melhor a forma como o olho humano percebe diferentes cores e seus brilhos relativos. A nomenclatura da classe `Luminosidade_R21_G71_B01` segue esse padrão para deixar claro as proporções utilizadas no cálculo de cada componente RGB.

## Uso

Para usar o conversor de imagem para ASCII, abra o projeto e defina o caminho da imagem e a resolução desejada. Os arquivos serão gerados na pasta raiz do projeto.


## Considerações

- Para melhor resultado, escolha resolução próxima de 100.
- A escolha dos caracteres ASCII pode ser ajustada para melhorar a qualidade visual.
- A resolução pode ser ajustada para equilibrar detalhes e tamanho da saída.

## Exemplo de Saída

Uma imagem simples poderia ser convertida em algo como:
```bash
###############################################################################################################################################
###############################################################################################################################################
####################################################################         ##################################################################
#############################################################                        ##########################################################
#########################################################               #                ######################################################
#####################################################               ################        ###################################################
###################################################                  ###################       ################################################
################################################                      #####################      ##############################################
##############################################                         #######################     ############################################
############################################                      ####  #########################    ##########################################
##########################################                       ##################################    ########################################
#########################################                       #####################################    ######################################
#######################################                        ########################################   #####################################
######################################                         #########################################    ###################################
####################################                          ############################################   ##################################
###################################                          ##############################################   #################################
##################################                          #################################################   ###############################
#################################                          ###################################################   ##############################
################################                          #####################################################   #############################
###############################                        #########################################################   ############################
##############################                         ##########################################################   ###########################
#############################                        #############################################################   ##########################
############################                       ################################################################   #########################
###########################                      ###################################################################   ########################
##########################                      #####################################################################   #######################
#########################                       ######################################################################  #######################
########################                        #######################################################################  ######################
########################                       ########################################################################   #####################
#######################                        #########################################################################   ####################
######################                         ##############  ###########  #############################################  ####################
######################                        ############       ##            ##########################################   ###################
#####################                        ###########                           #######################################  ###################
####################                         #########                                #####################################  ##################
####################                        ##########                                  ###################################   #################
###################                         #########                                   ####################################  #################
###################                         #########                                    ###################################   ################
##################                          ########                                     ##################     #############  ################
##################                          ########                                      ################         ##########   ###############
#################                           ########                                      ###############            ########   ###############
#################                           ########                                      ##############                  ####   ##############
#################                           ########                                      ########### #                      #   ##############
################   ##                       ########                                      ###########                            ##############
################  ########                  ########                                      ##########                              #############
################ #############              ########                                       #########                              #############
###############  #################          ########                                       #########                           #  #############
###############  ####################       ########                                       #########                 ############  ############
###############  #####################       ######                                        #########          ###################  ############
##############   ### #################       ######                                        #########         ##################### ############
##############  ##             ########      #####                                         #########        ###################### ############
##############  ##                #####       ####                                         #########        ######################  ###########
############## ###                #####       ####                              # ######    ########        ####################### ###########
#############  ###                #####       ####   #############           ############   ########         ###################### ###########
#############  ####               #####        ###  ###### #######           ####      ##   #######          ###################### ###########
#############  ####               #####        ###  ####                        ##       #  #######          ###################### ###########
#############  #####              #####        ###   #      ###                #######   #  ### ###         #######################  ##########
############# #######             #####        ###      #######                 #########   ##  ###         #######################  ##########
############# ##########      #########        ###    #########                  ### ###     ## ####        ######################## ##########
############# #########################        ###    ###  ###                               ##  ###        ######################## ##########
############# #########################         ##                                           ##  ###        ######################## ##########
############# #########################         ##                                               ###        ######################## ##########
############  #########################          #                                               ###        ######################## ##########
############  ##########################         #                        #                     ###         ######################## ##########
############  ##########################         #                        #                     ###         ######################## ##########
############  ###########################        #                 #      ##                    ###         ######################## ##########
############# ###########################        #                 #      ##                #   ###         ######################## ##########
############# ###########################        #                ##      ###               ## ####         ######################## ##########
############# ############################                       ##       ###               ## ####         ######################## ##########
############# ############################                       ##        ###              #######         ######################## ##########
############# #############################                     ###        ####             #######         ######################## ##########
############# #############################                     ####      #####             #######         ######################## ##########
############# #############################      #              #####    #####              #######         #######################  ##########
#############  ############################      #               ############               #######         ####################### ###########
#############  ###########################       #                ##########                #######         ####################### ###########
#############  ################    #######                        ##     ###               #########        ####################### ###########
#############   ##############     ########                               ##               #########        ####################### ###########
##############   ###########       ########                                               ##########        ####################### ###########
##############                      ######                                                ##########        ###################### ############
##############                      ######                    ######       #######       ###########        ###################### ############
##############                      ######                  ######################       ###########        ###################### ############
###############                     ######                  ##########     #######      ############        #####################  ############
###############                     ######                                             #############        ##################### #############
###############                     ######          #                                  #############        ##################### #############
################                #  ######           ##                                ###############       ####################  #############
################               ##########           ###                              ################       #################### ##############
################               ##########           ###                             ##################      #################### ##############
#################              ##########            ###                           ####################     ###################  ##############
#################              ###########            ###                         ## ###################    ################### ###############
##################            #############          ######                      ########################   ################### ###############
##################     ####################         ## #######                  ########################## ################### ################
###################  ############# ########        ###  ########             # ############################################### ################
###################  ############# #######       #####   ########       ##   ################################################ #################
####################  ###########               #####     ######### ########################################################  #################
####################   #                       ######      ################################################################# ##################
#####################                        #########     ################################################################  ##################
#####################                      ###########     ################################################################ ###################
######################                   #############     ############################################################### ####################
#######################               ################     ##############################################################  ####################
#######################            ####################     ############################################################# #####################
########################    #  ########################     ############################################################ ######################
#########################  #############################    ####################  #####################################  ######################
##########################  ############################     ##################   ####################################  #######################
##########################   ############################      ###############   ## #################################  ########################
###########################   ###########################        ############       ################################  #########################
############################  ############################         #########        ################################ ##########################
#############################  ############################            ###          ############################### ###########################
##############################  ###########################                        ##############################  ############################
###############################  ###########################                      ##############################  #############################
################################  ###########################                   ###############################  ##############################
#################################  ###########################                 ###############################  ###############################
###################################  ###########################             ################################  ################################
####################################  ######################################################################  #################################
#####################################  ###################################################################  ###################################
#######################################  ################################################################  ####################################
########################################  #############################################################  ######################################
##########################################  ##########################################################  #######################################
############################################  ######################################################  #########################################
#############################################   ##################################################  ###########################################
################################################  #############################################   #############################################
##################################################   ########################################   ###############################################
####################################################    ##################################   ##################################################
#######################################################     ##########################    #####################################################
###########################################################       ##############      #########################################################
################################################################                 ##############################################################
###############################################################################################################################################
###############################################################################################################################################
###############################################################################################################################################
```
