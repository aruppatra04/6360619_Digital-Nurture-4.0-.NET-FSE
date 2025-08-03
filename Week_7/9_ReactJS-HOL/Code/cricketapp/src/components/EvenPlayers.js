import React from 'react';

const EvenPlayers = (team) => {
  return (
    <ul>
      {team.map((player, index) => {
        if ((index + 1) % 2 === 0) {
          return (
            <li key={index}>
              {["Second", "Fourth", "Sixth"][Math.floor(index / 2)]} : {player}
            </li>
          );
        }
        return null;
      })}
    </ul>
  );
};

export default EvenPlayers;
