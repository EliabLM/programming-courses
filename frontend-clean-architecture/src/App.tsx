import './App.css';
import { Navbar } from '@/components';
import { Box } from '@mui/material';
import { Home } from './pages';

function App() {
  return (
    <>
      <Navbar />
      <Box pt={8}>
        <Home />
      </Box>
    </>
  );
}

export default App;
