import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className='App'>
      <header className='App-header'>
        <img src={logo} className='App-logo' alt='logo' />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className='App-link'
          href='https://eliablm.github.io/EliabLM/'
          target='_blank'
          rel='noopener noreferrer'
          data-testid='learn-link'
        >
          Eliab López
        </a>
      </header>
    </div>
  );
}

export default App;
