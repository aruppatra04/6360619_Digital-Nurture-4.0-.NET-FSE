import React from 'react';

const OddPlayers = (team) => {
  return (
    <ul>
      {team.map((player, index) => {
        if ((index + 1) % 2 !== 0) {
          return (
            <li key={index}>
              {["First", "Third", "Fifth"][Math.floor(index / 2)]} : {player}
            </li>
          );
        }
        return null;
      })}
    </ul>
  );
};

export default OddPlayers;
