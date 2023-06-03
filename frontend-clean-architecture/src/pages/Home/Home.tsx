import React from 'react';

import { DataGrid, GridRenderCellParams } from '@mui/x-data-grid';
import { People } from '@/data';

const Home: React.FC = () => {
  const pageSizeOptions = [5, 10, 20];
  const columns = [
    {
      field: 'name',
      headerName: 'Name',
      flex: 1,
      minWidth: 150,
      renderCell: (params: GridRenderCellParams) => <>{params.value}</>,
    },
    {
      field: 'category',
      headerName: 'Categories',
      flex: 1,
      minWidth: 150,
      renderCell: (params: GridRenderCellParams) => <>{params.value}</>,
    },
    {
      field: 'company',
      headerName: 'Company',
      flex: 1,
      minWidth: 150,
      renderCell: (params: GridRenderCellParams) => <>{params.value}</>,
    },
  ];

  return (
    <div>
      <DataGrid
        rows={People}
        columns={columns}
        disableColumnSelector
        disableRowSelectionOnClick
        autoHeight
        // autoPageSize
        pageSizeOptions={pageSizeOptions}
        getRowId={(row) => row.id}
      />
    </div>
  );
};

export default Home;
