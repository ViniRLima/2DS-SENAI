import { Component } from "react";

export default class repository extends Component{
    constructor(props){
        super(props);
        this.state = {
            repositorios : [],
            userName : '',
            id : 0,
            name : '',
            description : '',
            created_at : 0,
            size : 0
        };
    };

    atualizaEstadoNome = async (event) => {
        await this.setState({ userName: event.target.value })
        console.log(this.state.userName)
    }

    buscarRepositorio = () => {
        console.log('Chamada para a API.')

        fetch(`https://api.github.com/users/${this.state.userName}/repos?per_page=10&sort="OnOrder",Ascending,`)

        .then(resposta => resposta.json()).then(dados => this.setState({ repositorios: dados})).catch(erro => console.log(erro));
    }

    componentDidMount(){
    }


    render(){
        return(
            <div>
                <main>
                    <section>
                        <form onSubmit={this.buscarRepositorio}>
                        <div>
                            <input type='text' value={this.state.userName} placeholder='Username do GitHub' onChange={this.atualizaEstadoNome}/>
                            <button type='button' disabled={this.state.userName === '' ? 'none' : ''} onClick={() => this.buscarRepositorio()}>Enviar</button>
                        </div>
                        </form>

                        <h2 id='repositories'>Repositórios {this.state.userName === '' ? '': 'do ' + this.state.userName}</h2>
                        <table>
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Nome</th>
                                    <th>Descrição</th>
                                    <th>Data de criação</th>
                                    <th>Tamanho</th>
                                </tr>
                            </thead>

                            <tbody>
                                {
                                    this.state.repositorios.map((repositories => {
                                        return(
                                            <tr key={repositories.id}>
                                                <td>{repositories.id}</td>
                                                <td>{repositories.name}</td>
                                                <td>{repositories.description}</td>
                                                <td>{repositories.created_at}</td>
                                                <td>{repositories.size}</td>
                                            </tr>
                                        )
                                    }))
                                }
                            </tbody>
                        </table>
                        <a classname='App-link' href='http://localhost:3000/'>Voltar pra Home</a>
                    </section>
                </main>
            </div>
        )
    }
}