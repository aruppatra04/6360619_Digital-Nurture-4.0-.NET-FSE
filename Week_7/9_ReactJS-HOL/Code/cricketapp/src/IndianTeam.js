import React from 'react';
import ListofPlayers from './components/ListofPlayers';
import Scorebelow70 from './components/Scorebelow70';
import OddPlayers from './components/OddPlayers';
import EvenPlayers from './components/EvenPlayers';
import ListofIndianPlayers from './components/ListofIndianPlayers';

const IndianTeam = () => {
  const flag = true;

  const players = [
    { name: "Jack", score: 50 },
    { name: "Michael", score: 70 },
    { name: "John", score: 40 },
    { name: "Ann", score: 61 },
    { name: "Elisabeth", score: 61 },
    { name: "Sachin", score: 95 },
    { name: "Dhoni", score: 100 },
    { name: "Virat", score: 84 },
    { name: "Jadeja", score: 64 },
    { name: "Raina", score: 75 },
    { name: "Rohit", score: 80 }
  ];

  const IndianTeam = [
    "Sachin1", "Dhoni2", "Virat3", "Rohit4", "Yuvaraj5", "Raina6"
  ];

  const T20players = [
    "Mr. First Player",
    "Mr. Second Player",
    "Mr. Third Player"
  ];
  
  const RanjiTrophy = [
    "Mr. Fourth Player",
    "Mr. Fifth Player",
    "Mr. Sixth Player"
  ];

  const IndianPlayers = [...T20players, ...RanjiTrophy];

  if (flag === true) {
    return (
      <div style={{ padding: '20px', textAlign: 'left' }}>
        <ListofPlayers players={players} />
        <hr />
        <Scorebelow70 players={players} />
      </div>
    );
  } else {
    return (
      <div style={{ padding: '20px', textAlign: 'left' }}>
        <div>
          <h1>Odd Players</h1>
          {OddPlayers(IndianTeam)}
          <hr />
          <h1>Even Players</h1>
          {EvenPlayers(IndianTeam)}
        </div>
        <hr />
        <div>
          <h1>List of Indian Players Merged:</h1>
          <ListofIndianPlayers IndianPlayers={IndianPlayers} />
        </div>
      </div>
    );
  }
};

export default IndianTeam;
