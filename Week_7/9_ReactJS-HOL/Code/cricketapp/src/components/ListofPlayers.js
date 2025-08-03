import React from 'react';

const ListofPlayers = ({ players }) => {
  return (
    <div style={{ padding: '20px', textAlign: 'left' }}>
      <h1>List of Players</h1>
      <ul>
        {players.map((item, index) => (
          <li key={index}>
            Mr. {item.name} <span>{item.score}</span>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
