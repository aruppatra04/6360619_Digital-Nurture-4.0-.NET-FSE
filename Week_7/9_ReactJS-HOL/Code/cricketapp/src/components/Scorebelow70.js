import React from 'react';

const Scorebelow70 = ({ players }) => {
  const filteredPlayers = players.filter(player => player.score <= 70);

  return (
    <div style={{ padding: '20px', textAlign: 'left' }}>
      <h1>List of Players having Scores Less than 70</h1>
      <ul>
        {filteredPlayers.map((item, index) => (
          <li key={index}>
            Mr. {item.name} <span>{item.score}</span>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default Scorebelow70;
