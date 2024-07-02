import { useEffect, useState } from "react";
import { Link } from 'react-router-dom';
import axios from 'axios';

import '../App.js';

function MainPage() {

    const [games, setGames] = useState([]);
    const [error, setError] = useState(null);
    const [pending, setPending] = useState(true);

    useEffect(() => {
        axios.get('http://localhost:5094/GameModels')
            .then(response => {
                setGames(response.data);
                setError(null);
                setPending(false);
            })
            .catch(err => {
                setError(err.message);
                setPending(false);
            });
    }, [])

    const populateList = () => {
        let gameList = [];

        for(let game of games) {
            gameList.push(
                <li key={game.id}>
                    <Link to={"/GameModel/" + game.id} state={game}>
                        {game.name}
                    </Link>
                </li>
            )
        }

        return (
            <>
                {gameList}
            </>
        );
    }

    return (
        <div className="App-header text">

        {error && <div>{error}</div>}
        {pending && <div>Now loading...</div>}

        {games.length != 0 &&
        <div>
            <header>
                <div>
                    Game Finder
                </div>
                <div>
                    <ul>
                        {populateList()}
                    </ul>
                </div>
                
                </header>
        </div>
        }
        </div>
    );
}

export default MainPage;