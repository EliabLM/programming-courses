import { useQuery } from '@tanstack/react-query';

import { githubApi } from '../../api/githubApi';
import { sleep } from '../../helpers/sleep';
import { Label } from '../interfaces/label';

const getLabels = async (): Promise<Label[]> => {
  await sleep(2);
  const { data } = await githubApi.get<Label[]>('/labels');
  return data;
};

export const useLabels = () => {
  const labelsQuery = useQuery(['labels'], getLabels, {
    // staleTime: 1000 * 60 * 60, // Se mantiene la data fresca por una hora, antes de pasar a estado stale (caducada)
    // initialData: [],
    placeholderData: [
      {
        id: 69105383,
        node_id: 'MDU6TGFiZWw2OTEwNTM4Mw==',
        url: 'https://api.github.com/repos/facebook/react/labels/Browser:%20IE',
        name: 'Browser: IE',
        color: 'c7def8',
        default: false,
        description: undefined,
      },
    ],
  });
  return labelsQuery;
};
