﻿
class Carrinho {
    clickIncremento(btn) {
        let data = this.getData(btn);
        data.Qtd++;
        this.postQuantidade(data);
    }

    clickDecremento(btn){
        let data = this.getData(btn);
        data.Qtd--;
        this.postQuantidade(data);
    }

    getData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQtd = $(linhaDoItem).find('input').val();

        return {
            Id: itemId,
            Qtd: novaQtd
        };
    }

    postQuantidade(data) {
        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        });
    }
}

var carrinho = new Carrinho();


