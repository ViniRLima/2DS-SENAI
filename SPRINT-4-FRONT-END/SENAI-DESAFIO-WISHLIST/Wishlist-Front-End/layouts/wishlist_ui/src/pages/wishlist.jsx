import { Component } from 'react';

import './estilo.css'
import logo from '../img/logo.png'

export default class wishlist extends Component {
    constructor(props) {
        super(props);
        this.state = {
            listaDesejos: [],
            idWishlist: 0,
            idUsuario: 0,
            desejo: ''
        };
    };

    buscarDesejo = () => {
        console.log('Chamada para a API');

        fetch('http://localhost:5000/api/wishlists').then(r => r.json()).then(dados => this.setState({ listaDesejos: dados })).catch(erro => console.log(erro))
    }

    atualizaEstadoDesejo = async (event) => {
        await this.setState({ desejo: event.target.value })
        console.log(this.state.desejo)
    };

    atualizaEstadoId = async (event) => {
        await this.setState({ idUsuario: event.target.value })
        console.log(this.state.idUsuario)
    }

    componentDidMount() {
        this.buscarDesejo();
    }

    inserirDesejo = (event) => {
        event.preventDefault();

        fetch('http://localhost:5000/api/wishlists', {
            method: 'POST',
            body: JSON.stringify({ idUsuario: this.state.idUsuario, desejo: this.state.desejo }),
            headers: {
                "Content-type": "application/json"
            }
        })

            .then(console.log('O seu desejo ' + this.state.desejo + ' foi cadastrado!'))

            // caso ocorra algum erro, mostra no console do navegador
            .catch(erro => console.log(erro))

            .then(this.buscarDesejo)

            .then(this.limparCampos)
    }
    limparCampos = () => {
        this.setState(
            {
                idUsuario : 0,
                desejo : ''
            })
    }


    render() {
        return (
            <div>
                <main>
                    <header>
                        <img src={logo} alt="logo"></img>
                    </header>
                    <form onSubmit={this.inserirDesejo} className="container_id_desejo">
                        <div className="container_id">
                            <span>Meu Id é: </span>
                            <input className="input_id" type="number" value={this.state.idUsuario} onChange={this.atualizaEstadoId}></input>
                        </div>
                        <div className="container_desejo">
                            <span>Eu desejo: </span>
                            <input className="input_desejo" type="text" value={this.state.desejo} onChange={this.atualizaEstadoDesejo}></input>
                            <button className="button_desejo" type="submit" >Escrever</button>
                        </div>
                    </form>


                    <div className="container_text">

                        <h2>Lista de desejos</h2>

                    </div>


                    <section className="container_resultado">
                        <div className="container_rs">
                            <table className="container_tabela">
                                <thead >
                                    <tr className="container_resultado_titulo">
                                        <th className="container_id_desejo_ra">Id</th>
                                        <th className="container_id_desejo_ra">Desejo</th>
                                    </tr>
                                </thead>

                                <tbody >
                                    {
                                        this.state.listaDesejos.map((desejos) => {
                                            return (
                                                <tr key={desejos.idWishlist} className="container_resultado_amostra" >
                                                    <td className="container_id_desejo_td">{desejos.idWishlist}</td>
                                                    <td className="container_id_desejo_td">{desejos.desejo}</td>
                                                </tr>
                                            )
                                        })
                                    }

                                </tbody>
                            </table>
                        </div>

                    </section>

                </main>
            </div>
        )
    }

}